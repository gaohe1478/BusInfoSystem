using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket1.Models;

namespace Ticket1
{
    public partial class allticket : Form
    {
        public allticket()
        {
            InitializeComponent();
            using (busticketContext context = new busticketContext())
            {
                List<Ticket> list1 = context.Ticket.ToList();
                foreach (var temp in list1)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Tid;
                    item.SubItems.Add(temp.UserId);
                    item.SubItems.Add(temp.UserName);
                    item.SubItems.Add(Convert.ToString(temp.UserIdCode));
                    item.SubItems.Add(temp.BusCode);
                    item.SubItems.Add(temp.InfoId);
                    item.SubItems.Add(temp.Start);
                    item.SubItems.Add(temp.End);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(temp.EndTime);
                    item.SubItems.Add(temp.Price);
                    item.SubItems.Add(temp.CreatTime);
                    listView1.Items.Add(item);
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Allticket_Load(object sender, EventArgs e)
        {

        }
    }
}
