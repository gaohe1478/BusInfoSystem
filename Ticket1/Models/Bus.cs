using System;
using System.Collections.Generic;

namespace Ticket1.Models
{
    public partial class Bus
    {
        public Bus()
        {
            Ticket = new HashSet<Ticket>();
        }

        public string BusCode { get; set; }
        public string Driver { get; set; }
        public int? SeatNum { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
