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
    public partial class addBus : Form
    {
        public addBus()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Bus bus = new Bus();
                bus.BusCode = textBox1.Text;
                bus.Driver = textBox2.Text;
                bus.SeatNum = int.Parse(textBox3.Text);
                bus.Type = textBox4.Text;
                Bus temp = context.Bus.FirstOrDefault(x => x.BusCode == bus.BusCode);
                if (temp != null)
                {
                    MessageBox.Show("此车辆已存在！", "提示");
                }
                else
                {
                    context.Add(bus);
                    MessageBox.Show("添加成功！", "提示");
                    context.SaveChanges();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                
                Bus temp = context.Bus.FirstOrDefault(x => x.BusCode == textBox1.Text);
                if (temp == null)
                {
                    MessageBox.Show("此车辆不存在！", "提示");
                }
                else
                {
                    temp.Driver = textBox2.Text;
                    temp.SeatNum = int.Parse(textBox3.Text);
                    temp.Type = textBox4.Text;
                    MessageBox.Show("修改成功！", "提示");
                    context.SaveChanges();
                }
            }
        }

        private void AddBus_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Bus temp = context.Bus.FirstOrDefault(x => x.BusCode == textBox1.Text);
                if (temp == null)
                {
                    MessageBox.Show("此车不存在！", "提示");
                }
                else
                {
                    textBox2.Text = temp.Driver;
                    textBox3.Text = Convert.ToString(temp.SeatNum);
                    textBox4.Text = temp.Type;

                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Bus temp = context.Bus.FirstOrDefault(x => x.BusCode == textBox1.Text);
                if (temp == null)
                {
                    MessageBox.Show("此车不存在！", "提示");
                }
                else
                {
                    context.Bus.Remove(temp);
                    MessageBox.Show("删除成功！", "提示");
                    context.SaveChanges();
                }
            }
        }
    }
}
