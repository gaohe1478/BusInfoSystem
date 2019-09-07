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
    public partial class buyticket : Form
    {
        public buyticket()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Buyticket_Load(object sender, EventArgs e)
        {

        }

        public string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            using (busticketContext context = new busticketContext()) {
                Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(x => x.Bid == textBox1.Text);
                if (bookinfo != null)
                {
                    textBox2.Text = bookinfo.Bid;
                    textBox3.Text = bookinfo.Start;
                    textBox4.Text = bookinfo.End;
                    textBox5.Text = bookinfo.StartTime;
                    textBox6.Text = bookinfo.EndTime;
                    textBox7.Text = bookinfo.BusCode;
                    textBox8.Text = Convert.ToString(bookinfo.Count);
                    textBox9.Text = bookinfo.Price;
                }
                else {
                    MessageBox.Show("线路不存在，请输入正确的线路ID！", "提示");
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定购买本线路车票？","提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                using (busticketContext context = new busticketContext()) {
                    User temp = context.User.FirstOrDefault(x => x.Id == common.id);
                    Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(x => x.Bid == textBox1.Text);
                    if (bookinfo.Count>0) {
                        Ticket ticket = new Ticket();
                        ticket.BusCode = bookinfo.BusCode;
                        ticket.Tid = GetRandomString(12, true, true, true, false, "Tk");
                        ticket.UserId = temp.Id;
                        ticket.UserName = temp.Name;
                        ticket.Price = bookinfo.Price;
                        ticket.InfoId = bookinfo.Bid;
                        ticket.Start = bookinfo.Start;
                        ticket.StartTime = bookinfo.StartTime;
                        ticket.End = bookinfo.End;
                        ticket.EndTime = bookinfo.EndTime;
                        ticket.UserIdCode = temp.IdCode;
                        ticket.CreatTime = DateTime.Now.ToString();
                        context.Add(ticket);
                        MessageBox.Show("购买成功！", "提示");
                        bookinfo.Count--;
                        context.SaveChanges();
                    }
                    else {
                        MessageBox.Show("票已售完！", "提示");
                    }

                    

                }
                    
            }
            
        }
    }
}
