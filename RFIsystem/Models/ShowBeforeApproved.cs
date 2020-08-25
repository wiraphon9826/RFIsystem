using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RFIsystem.Models
{
    public class ShowBeforeApproved
    {
        public string Job_no { get; set; }
        public string User_name { get; set; }
        public string Frist_name { get; set; }
        public string Prepared { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PreparedDate { get; set; }
        public string PreparedBy { get; set; }
        public string Verified { get; set; }

        public string VerifiedDate { get; set; }
        public string VerifiedBy { get; set; }
        public string Received { get; set; }
        public string ReceivedDate { get; set; }
        public string ReceivedBy { get; set; }



    }
}
