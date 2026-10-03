using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }
    }
}
