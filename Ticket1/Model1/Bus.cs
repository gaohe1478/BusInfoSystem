using System;
using System.Collections.Generic;

namespace Ticket1.Model1
{
    public partial class Bus
    {
        public Bus()
        {
            Bookinfo = new HashSet<Bookinfo>();
        }

        public string BusCode { get; set; }
        public string Driver { get; set; }
        public int? SeatNum { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Bookinfo> Bookinfo { get; set; }
    }
}
