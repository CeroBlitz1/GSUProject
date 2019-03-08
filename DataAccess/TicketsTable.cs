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
    
    public partial class TicketsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TicketsTable()
        {
            this.PaymentHistoryTables = new HashSet<PaymentHistoryTable>();
        }
    
        public int TicketID { get; set; }
        public Nullable<int> TicketQuantity { get; set; }
        public Nullable<int> TicketPrice { get; set; }
        public Nullable<int> EventID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModfiedDate { get; set; }
        public Nullable<int> TicketsPurchased { get; set; }
        public Nullable<int> TicketsRemining { get; set; }
        public Nullable<int> isDelete { get; set; }
    
        public virtual EventsTable EventsTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistoryTable> PaymentHistoryTables { get; set; }
    }
}
