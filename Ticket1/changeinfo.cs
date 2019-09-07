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
    public partial class changeinfo : Form
    {
        public changeinfo()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Changeinfo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {

                User temp = context.User.FirstOrDefault(x => x.Id == common.id);
                if (temp != null)
                {
                    temp.Name = textBox2.Text;
                    temp.IdCode = int.Parse(textBox3.Text);
                    temp.Sex = textBox4.Text;
                    temp.Age = int.Parse(textBox5.Text);
                    MessageBox.Show("修改成功！", "提示");
                    context.SaveChanges();

                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}