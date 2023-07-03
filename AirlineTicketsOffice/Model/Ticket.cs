//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineTicketsOffice.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int id { get; set; }
        public Nullable<int> Passage_id { get; set; }
        public string PassangerName { get; set; }
        public System.DateTime Date { get; set; }
        public string Passport { get; set; }
        public System.DateTime PassportDate { get; set; }
        public int Till { get; set; }
        public int TicketNumber { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Registrar_id { get; set; }
        public Nullable<int> Seat_id { get; set; }
    
        public virtual Passage Passage { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual User User { get; set; }
    }
}
