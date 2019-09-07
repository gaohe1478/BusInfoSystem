using System;
using System.Collections.Generic;

namespace Ticket1.Models
{
    public partial class User
    {
        public User()
        {
            Ticket = new HashSet<Ticket>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int? IdCode { get; set; }
        public string Sex { get; set; }
        public int? Age { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
