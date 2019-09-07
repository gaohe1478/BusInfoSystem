using System;
using System.Collections.Generic;

namespace Ticket1.Models
{
    public partial class Ticket
    {
        public string Tid { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int? UserIdCode { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string BusCode { get; set; }
        public string InfoId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Price { get; set; }
        public string CreatTime { get; set; }

        public virtual Bus BusCodeNavigation { get; set; }
        public virtual Bookinfo Info { get; set; }
        public virtual User User { get; set; }
    }
}
