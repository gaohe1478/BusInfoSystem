using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket1
{
    public partial class BusInfoMangeSystem : Form
    {
        public BusInfoMangeSystem()
        {
            InitializeComponent();
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Userbutton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            lookinfo form = new lookinfo { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            changeinfo form = new changeinfo { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            userpassword form = new userpassword { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            buyticket form = new buyticket { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            userquery form = new userquery { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            userticket form = new userticket { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }
    }
}
