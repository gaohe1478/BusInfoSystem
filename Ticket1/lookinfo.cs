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
    public partial class lookinfo : Form
    {
        public lookinfo()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Lookinfo_Load(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext()) {
                
                User temp = context.User.FirstOrDefault(x => x.Id == common.id);
                if (temp != null)
                {
                    textBox1.Text = temp.Id;
                    textBox2.Text = temp.Name;
                    textBox3.Text = Convert.ToString(temp.IdCode);
                    textBox4.Text = temp.Sex;
                    textBox5.Text = Convert.ToString(temp.Age);
                }
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
