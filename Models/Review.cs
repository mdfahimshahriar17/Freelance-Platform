using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int ProjectID { get; set; }

        public int ReviewerID { get; set; }

        public int FreelancerID { get; set; }

        public string Comment { get; set; }

        public byte Rating { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}