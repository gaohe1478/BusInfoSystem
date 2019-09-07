using System;
using System.Collections.Generic;

namespace Ticket1.Model1
{
    public partial class Bookinfo
    {
        public string Bid { get; set; }
        public string Lid { get; set; }
        public string BusCode { get; set; }
        public string StartTime { get; set; }
        public int? Surplus { get; set; }
        public string Usetime { get; set; }
        public string Price0 { get; set; }
        public string Price1 { get; set; }
        public string Price2 { get; set; }
        public string Price3 { get; set; }

        public virtual Bus BusCodeNavigation { get; set; }
        public virtual Line L { get; set; }
    }
}
