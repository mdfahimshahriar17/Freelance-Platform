using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Data;
using P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Models;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Services
{
    public static class AuthService
    {
        public static bool UsernameExists(string username)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM tblUser
                    WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static bool EmailExists(string email)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM tblUser
                    WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static bool RegisterUser(
            string username,
            string email,
            string password,
            UserRole role)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO tblUser
                    (
                        Username,
                        Password,
                        Email,
                        Role,
                        CreateDate,
                        IsActive
                    )
                    VALUES
                    (
                        @Username,
                        @Password,
                        @Email,
                        @Role,
                        GETDATE(),
                        1
                    )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", HashPassword(password));
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role.ToString());

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public static User LoginUser(string username, string password)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT
                        UserID,
                        Username,
                        Password,
                        Email,
                        Role,
                        CreateDate,
                        IsActive
                    FROM tblUser
                    WHERE Username = @Username
                    AND Password = @Password
                    AND IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue(
                        "@Password",
                        HashPassword(password)
                    );

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Email = reader["Email"].ToString(),
                                Role = (UserRole)Enum.Parse(
                                    typeof(UserRole),
                                    reader["Role"].ToString()
                                ),
                                CreateDate = Convert.ToDateTime(
                                    reader["CreateDate"]
                                ),
                                IsActive = Convert.ToBoolean(
                                    reader["IsActive"]
                                )
                            };
                        }
                    }
                }
            }

            return null;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();

                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}