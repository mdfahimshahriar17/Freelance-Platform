using System.Data.SqlClient;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Data
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FreelancePlatformDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}