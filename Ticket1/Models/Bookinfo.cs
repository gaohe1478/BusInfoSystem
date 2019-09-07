using System;
using System.Collections.Generic;

namespace Ticket1.Models
{
    public partial class Bookinfo
    {
        public Bookinfo()
        {
            Ticket = new HashSet<Ticket>();
        }

        public string Bid { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string BusCode { get; set; }
        public int? Count { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
