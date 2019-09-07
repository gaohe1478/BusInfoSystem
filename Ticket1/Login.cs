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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\software\\vs projects\\Ticket1\\timg.jpg");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (busticketContext context = new busticketContext())
            {
                Admin admin = new Admin();
                User user = new User();
                string id = textBox1.Text;
                string password = textBox2.Text;

                if (checkBox1.Checked == true)
                {
                    if (id != null && password != null)
                    {
                        Admin temp = context.Admin.Find(id);
                        if (temp == null)
                        {
                            MessageBox.Show("用户不存在！", "提示");
                        }
                        else
                        {
                            if (temp.Id == id && temp.Password == password)
                            {
                                MessageBox.Show("登陆成功！", "提示");
                                this.DialogResult = DialogResult.OK;
                                common.id = id;
                                this.Dispose();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("密码错误！", "提示");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入错误！", "提示");
                    }
                }
                else {
                    if (id != null && password != null)
                    {
                        User temp = context.User.Find(id);
                        if (temp == null)
                        {
                            MessageBox.Show("用户不存在！", "提示");
                        }
                        else
                        {
                            if (temp.Id == id && temp.Password == password)
                            {
                                MessageBox.Show("登陆成功！", "提示");
                                this.DialogResult = DialogResult.No;
                                common.id= id;
                                this.Dispose();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("密码错误！", "提示");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入错误！", "提示");
                    }
                }
                    

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;
            using (busticketContext context = new busticketContext()) {
                User temp = context.User.Find(id);
                if (id != "" && password != "")
                {
                    if (temp != null)
                    {
                        MessageBox.Show("用户已存在！", "提示");
                    }
                    else
                    {
                        User user = new User();
                        user.Id = id;
                        user.Password = password;
                        context.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("注册成功！", "提示");
                    }
                }
                else {
                    MessageBox.Show("请完善用户名和密码！", "提示");
                }


            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
