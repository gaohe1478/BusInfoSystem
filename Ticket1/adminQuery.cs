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
    public partial class adminQuery : Form
    {
        public adminQuery()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext()) {
                if (checkBox1.Checked == true)
                {
                    List<Bookinfo> list1 = context.Bookinfo.ToList();
                    foreach (var temp in list1)
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
                else {
                    List<Bookinfo> list = context.Bookinfo.Where(u => u.End ==textBox1.Text).ToList();
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
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
