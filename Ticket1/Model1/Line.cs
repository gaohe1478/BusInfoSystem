using System;
using System.Collections.Generic;

namespace Ticket1.Model1
{
    public partial class Line
    {
        public Line()
        {
            Bookinfo = new HashSet<Bookinfo>();
        }

        public string Lid { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Mid0 { get; set; }
        public string Mid1 { get; set; }
        public string Mid2 { get; set; }

        public virtual ICollection<Bookinfo> Bookinfo { get; set; }
    }
}
