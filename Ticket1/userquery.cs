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
    public partial class userquery : Form
    {
        public userquery()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext()) {
                List<Bookinfo> list = context.Bookinfo.Where(u => u.End == textBox1.Text).ToList();
                foreach (var temp in list)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(temp.Start);
                    item.SubItems.Add(temp.End);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(temp.EndTime);
                    item.SubItems.Add(temp.BusCode);
                    item.SubItems.Add(Convert.ToString(temp.Count));
                    item.SubItems.Add(temp.Price);
                    listView1.Items.Add(item);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
