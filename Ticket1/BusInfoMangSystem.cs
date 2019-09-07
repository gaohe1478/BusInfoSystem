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
    public partial class BusInfoMangSystem : Form
    {
        public BusInfoMangSystem()
        {
            InitializeComponent();
            
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            adminAdd  form = new adminAdd { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            adminQuery form = new adminQuery { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Adminupdate form = new Adminupdate { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            addBus form = new addBus { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            allticket form = new allticket { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            password form = new password { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form);
            form.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
