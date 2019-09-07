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
    public partial class Adminupdate : Form
    {
        public Adminupdate()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext()) {
                Bookinfo temp = context.Bookinfo.FirstOrDefault(x => x.Bid == textBox1.Text);
                if (temp == null)
                {
                    MessageBox.Show("线路不存在！", "提示");
                }
                else {
                    textBox2.Text = temp.Start;
                    textBox3.Text = temp.End;
                    textBox4.Text = temp.StartTime;
                    textBox5.Text = temp.EndTime;
                    textBox6.Text = temp.BusCode;
                    textBox7.Text = Convert.ToString(temp.Count);
                    textBox8.Text = temp.Price;

                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text ="";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Bookinfo temp = context.Bookinfo.FirstOrDefault(x => x.Bid == textBox1.Text);
                if (temp == null)
                {
                    MessageBox.Show("线路不存在！", "提示");
                }
                else
                {
                    temp.Start = textBox2.Text;
                    temp.End =  textBox3.Text;
                    temp.StartTime = textBox4.Text;
                    temp.EndTime = textBox5.Text;
                    temp.BusCode = textBox6.Text;
                    temp.Count = int.Parse(textBox7.Text);
                    temp.Price = textBox8.Text;
                    MessageBox.Show("更新成功！", "提示");
                    context.SaveChanges();

                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Bookinfo temp = context.Bookinfo.FirstOrDefault(x => x.Bid == textBox1.Text);
                if (temp == null)
                {
                    MessageBox.Show("线路不存在！", "提示");
                }
                else
                {
                    context.Bookinfo.Remove(temp);
                    MessageBox.Show("删除成功！", "提示");
                    context.SaveChanges();

                }
            }
        }

        private void Adminupdate_Load(object sender, EventArgs e)
        {

        }
    }
}
