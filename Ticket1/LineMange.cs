using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket1.Model1;

namespace Ticket1
{
    public partial class LineMange : Form
    {
        public LineMange()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)//AddLine()
        {
            using (busContext context = new busContext())
            {
                //Line line = new Line();
                //line.Lid = textBox6.Text;
                //line.Start = textBox1.Text;
                //line.Mid0 = textBox2.Text;
                //line.Mid1 = textBox3.Text;
                //line.Mid2 = textBox4.Text;
                //line.End = textBox5.Text;
                Line line = GetLine();
                Line temp = context.Line.FirstOrDefault(x => x.Lid == line.Lid);
                if (temp != null)
                {
                    MessageBox.Show("此线路已存在！", "提示");
                }
                else
                {
                    if (line.Start != null && line.End != null)
                    {
                        bool x = Format(line);
                        //Regex reg = new Regex("^[\u4E00-\u9FA5]{0,}$");
                        //bool isMatchStart = reg.IsMatch(line.Start);      //Ture则为汉字
                        //bool isMatchEnd = reg.IsMatch(line.End);
                        //bool isMatchMid0, isMatchMid1, isMatchMid2;
                        //if (line.Mid0 == null)
                        //{
                        //    isMatchMid0 = true;
                        //}
                        //else
                        //{
                        //    isMatchMid0 = reg.IsMatch(line.Mid0);
                        //}
                        //if (line.Mid1 == null)
                        //{
                        //    isMatchMid1 = true;
                        //}
                        //else
                        //{
                        //    isMatchMid1 = reg.IsMatch(line.Mid1);
                        //}
                        //if (line.Mid2 == null)
                        //{
                        //    isMatchMid2 = true;
                        //}
                        //else
                        //{
                        //    isMatchMid2 = reg.IsMatch(line.Mid2);
                        //}

                        if (x)
                        {
                            context.Line.Add(line);
                            context.SaveChanges();
                            MessageBox.Show("添加成功！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("输入格式有误！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入有误！", "提示");
                    }




                }
            }
        }

        public Line GetLine() {
            Line line = new Line();
            line.Lid = textBox6.Text;
            line.Start = textBox1.Text;
            line.Mid0 = textBox2.Text;
            line.Mid1 = textBox3.Text;
            line.Mid2 = textBox4.Text;
            line.End = textBox5.Text;
            return line;
        }

        public bool Format(Line line) {
            Regex reg = new Regex("^[\u4E00-\u9FA5]{0,}$");
            bool isMatchStart = reg.IsMatch(line.Start);      //Ture则为汉字
            bool isMatchEnd = reg.IsMatch(line.End);
            bool isMatchMid0, isMatchMid1, isMatchMid2;
            if (line.Mid0 == null)
            {
                isMatchMid0 = true;
            }
            else
            {
                isMatchMid0 = reg.IsMatch(line.Mid0);
            }
            if (line.Mid1 == null)
            {
                isMatchMid1 = true;
            }
            else
            {
                isMatchMid1 = reg.IsMatch(line.Mid1);
            }
            if (line.Mid2 == null)
            {
                isMatchMid2 = true;
            }
            else
            {
                isMatchMid2 = reg.IsMatch(line.Mid2);
            }
            if (isMatchStart && isMatchMid1 && isMatchMid2 && isMatchMid0 && isMatchEnd)
            {
                return true;
            }
            else {
                return false;
            }

        }

        private void Button2_Click(object sender, EventArgs e)//QueryLine()
        {
            string id = GetId();
            string str = @"^\d+$";
            Regex regex = new Regex(str);
            bool match = regex.IsMatch(id);
            if (textBox6.Text == null || !match)
            {
                MessageBox.Show("输入格式有误！", "提示");
            }
            else
            {
                using (busContext context = new busContext())
                {
                    Line temp = context.Line.FirstOrDefault(x => x.Lid == id);
                    if (temp == null)
                    {
                        MessageBox.Show("不存在本线路！", "提示");
                    }
                    else
                    {
                        SetValue(temp);
                    }
                }
            }
        }

        public string GetId() {
            string id = textBox6.Text;
            return id;
        }
        public void SetValue(Line temp) {
            textBox1.Text = temp.Start;
            textBox2.Text = temp.Mid0;
            textBox3.Text = temp.Mid1;
            textBox4.Text = temp.Mid2;
            textBox5.Text = temp.End;
        }

        private void Button5_Click(object sender, EventArgs e)//Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)//ChangeLine()
        {
            using (busContext context = new busContext())
            {
                string id = GetId();
                Line temp = context.Line.FirstOrDefault(x => x.Lid == id);
                if (temp == null)
                {
                    MessageBox.Show("不存在本线路！", "提示");
                }
                else
                {
                    Line line1 = CreatLineNoId(temp);
                    if (line1.Start != null && line1.End != null)
                    {

                        bool x = Format(line1);
                        //Regex reg = new Regex("^[\u4E00-\u9FA5]{0,}$");
                        //bool isMatchStart = reg.IsMatch(line1.Start);      //Ture则为汉字
                        //bool isMatchEnd = reg.IsMatch(line1.End);
                        //bool isMatchMid0, isMatchMid1, isMatchMid2;
                        //if(line1.Mid0 == null)
                        //{
                        //    isMatchMid0 = true;
                        //}
                        //else
                        //{
                        //    isMatchMid0 = reg.IsMatch(line1.Mid0);
                        //}
                        //if (line1.Mid1 == null)
                        //{
                        //    isMatchMid1 = true;
                        //}
                        //else
                        //{
                        //    isMatchMid1 = reg.IsMatch(line1.Mid1);
                        //}
                        //if (line1.Mid2 == null)
                        //{
                        //    isMatchMid2 = true;
                        //}
                        //else
                        //{
                        //    isMatchMid2 = reg.IsMatch(line1.Mid2);
                        //}

                        if (x)
                        {
                            //temp.Start = textBox1.Text;
                            //temp.Mid0 = textBox2.Text;
                            //temp.Mid1 = textBox3.Text;
                            //temp.Mid2 = textBox4.Text;
                            //temp.End = textBox5.Text;
                            //context.SaveChanges();
                            ChangeLineInfo(line1);
                            MessageBox.Show("修改成功！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("输入格式有误！", "提示");
                        }
                    }
                }

            }
        }
        public Line CreatLineNoId(Line temp) {
            Line line = new Line();
            line.Lid = temp.Lid;
            line.Start = textBox1.Text;
            line.Mid0 = textBox2.Text;
            line.Mid1 = textBox3.Text;
            line.Mid2 = textBox4.Text;
            line.End = textBox5.Text;
            return line;
        }
        public void ChangeLineInfo(Line line){
            using (busContext context = new busContext())
            {
                Line temp = context.Line.FirstOrDefault(x => x.Lid == line.Lid);
                temp.Start = line.Start;
                temp.Mid0 = line.Mid0;
                temp.Mid1 = line.Mid1;
                temp.Mid2 = line.Mid2;
                temp.End = line.End;
                context.SaveChanges();
            }
                
        }

        private void Button4_Click(object sender, EventArgs e)//DeleteLine()
        {
            using (busContext context = new busContext()) {
                string id = GetId();
                string str = @"^\d+$";
                Regex regex = new Regex(str);
                bool match = regex.IsMatch(id);
                Line temp = context.Line.FirstOrDefault(x => x.Lid == id);
                if (temp == null&&!match)
                {
                    MessageBox.Show("不存在本线路！", "提示");
                }
                else {
                    DialogResult result = MessageBox.Show("确定删除本线路？（删除会导致使用本线路的车次被删除）", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(x => x.Lid == temp.Lid);
                        //if (bookinfo == null)
                        //{
                        //    context.Remove(temp);
                        //    context.SaveChanges();
                        //    MessageBox.Show("删除成功！", "提示");
                        //}
                        //else
                        //{
                        //    context.Remove(temp);
                        //    context.Remove(bookinfo);
                        //    context.SaveChanges();
                        //    MessageBox.Show("删除成功，使用本线路的车次也被删除！", "提示");
                        //}
                        
                    }
                    
                }
            }
        }

        public void  DeleteLine(Line temp) {
            using (busContext context = new busContext())
            {
                Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(x => x.Lid == temp.Lid);
                if (bookinfo == null)
                {
                    context.Remove(temp);
                    context.SaveChanges();
                    MessageBox.Show("删除成功！", "提示");
                }
                else
                {
                    context.Remove(temp);
                    context.Remove(bookinfo);
                    context.SaveChanges();
                    MessageBox.Show("删除成功，使用本线路的车次也被删除！", "提示");
                }
            }
                
        }

        private void Xianluguanli_Load(object sender, EventArgs e)
        {

        }
    }
}
