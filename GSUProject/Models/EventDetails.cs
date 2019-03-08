using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GSUProject.Models
{
    public class EventDetails
    {
        [Key]
        public int EventID { get; set; }
        public string EventLocation { get; set; }
        public DateTime EventDate { get; set; }
        public string EventType { get; set; }
        public string EventImage { get; set; }
        public string EventTitle { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int isDelete { get; set; }
    }
}