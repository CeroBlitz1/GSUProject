using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class EventModel
    {
        
        
        
        public int EventID { get; set; }
        public int UserId { get; set; }
        public string EventLocation { get; set; }
        public string EventType { get; set; }
        public string EventImage { get; set; }
        public string EventTitle { get; set; }
        public DateTime EventDate { get; set; }
        public int TicketID { get; set; }
        public int TicketQuantity { get; set; }
        public int TicketPrice { get; set; }
        public string TicketImage { get; set; }
        public bool EFlag { get; set; }
        public string EMessage { get; set; }
        public string EventsDescription { get; set; }
        public int TicketsPurchased { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MaxTickets { get; set; }
        public int isDelete { get; set; }
    }
}
