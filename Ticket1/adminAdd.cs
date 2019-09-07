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
    public partial class adminAdd : Form
    {
        public adminAdd()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Bookinfo bookinfo = new Bookinfo();
                bookinfo.Bid = textBox1.Text;
                bookinfo.Start = textBox2.Text;
                bookinfo.End = textBox3.Text;
                bookinfo.StartTime = textBox4.Text;
                bookinfo.EndTime = textBox5.Text;
                bookinfo.BusCode = textBox6.Text;
                bookinfo.Count = int.Parse(textBox7.Text);
                bookinfo.Price = textBox8.Text;
                Bookinfo temp = context.Bookinfo.FirstOrDefault(x => x.Bid ==bookinfo.Bid);
                if (temp != null)
                {
                    MessageBox.Show("线路已存在！", "提示");
                }
                else {
                    context.Add(bookinfo);
                    MessageBox.Show("添加成功！", "提示");
                    context.SaveChanges();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
           
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
