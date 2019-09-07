using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket1.Model1;

namespace Ticket1
{
    public partial class chashan1 : Form
    {
        public chashan1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)//QueryTicketById()
        {
            using (busContext context = new busContext())
            {
                string id = GetUserId();
                List<Ticket> list1 = context.Ticket.Where(u => u.Uid == id).ToList();
                foreach (var temp in list1)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Tid;
                    item.SubItems.Add(temp.Uid);
                    item.SubItems.Add(temp.UserName);
                    item.SubItems.Add(Convert.ToString(temp.UserIdCode));
                    item.SubItems.Add(temp.BusCode);

                    item.SubItems.Add(temp.Start);
                    item.SubItems.Add(temp.End);
                    item.SubItems.Add(temp.StartTime);
                    
                    item.SubItems.Add(temp.Price);
                    item.SubItems.Add(temp.creattime);

                    listView1.Items.Add(item);
                }
            }
        }
        public string  GetUserId() {
            string id = textBox1.Text;
            return id;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//CanelTicket()
        {
            DialogResult result = MessageBox.Show("确定取消本订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i];
                    using (busContext context = new busContext())
                    {
                        Ticket ticket = context.Ticket.FirstOrDefault(x => x.Tid == item.Text);
                        Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(x => x.Bid == ticket.Bid);
                        DateTime dt;
                        DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                        dtFormat.ShortDatePattern = "yyyy/MM/dd hh:mm";
                        dt = Convert.ToDateTime(ticket.StartTime, dtFormat);
                        var now = DateTime.Now;
                        if (DateTime.Compare(dt, now) > 0)
                        {
                            bookinfo.Surplus++;
                            context.Remove(ticket);
                            context.SaveChanges();
                            MessageBox.Show("取消订单成功  ！", "提示");
                            listView1.Items.Remove(item);
                        }
                        else
                        {
                            MessageBox.Show("订单已经过期，无法取消  ！", "提示");
                        }
                    }
                    
                }
            }
                
        }
    }
}
