using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Models
{
    public class Bid
    {
        public int BidID { get; set; }

        public int ProjectID { get; set; }

        public string Proposal { get; set; }

        public decimal Amount { get; set; }

        public DateTime SubmissionDate { get; set; }

        public int UserID { get; set; }

        public string Status { get; set; }
    }
}