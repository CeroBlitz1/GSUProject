//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventsTable()
        {
            this.EventDetails = new HashSet<EventDetail>();
            this.PaymentHistoryTables = new HashSet<PaymentHistoryTable>();
            this.TicketsTables = new HashSet<TicketsTable>();
        }
    
        public int EventID { get; set; }
        public string EventLocation { get; set; }
        public System.DateTime EventDate { get; set; }
        public string EventType { get; set; }
        public string EventImage { get; set; }
        public string EventTitle { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> isDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventDetail> EventDetails { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistoryTable> PaymentHistoryTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketsTable> TicketsTables { get; set; }
    }
}
