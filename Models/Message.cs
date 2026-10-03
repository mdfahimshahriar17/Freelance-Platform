using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Models
{
    public class Message
    {
        public int MessageID { get; set; }

        public string Content { get; set; }

        public DateTime SendDate { get; set; }

        public int SenderID { get; set; }

        public int ReceiverID { get; set; }
    }
}