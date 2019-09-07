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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {

                Admin temp = context.Admin.FirstOrDefault(x => x.Id == common.id);
                if (temp.Password == textBox1.Text)
                {
                    temp.Password = textBox2.Text;
                    MessageBox.Show("修改成功！", "提示");
                    context.SaveChanges();
                }
                else {
                    MessageBox.Show("原密码错误！", "提示");
                }
            }
        }

        private void Password_Load(object sender, EventArgs e)
        {
            textBox3.Text = common.id;
        }
    }
}
