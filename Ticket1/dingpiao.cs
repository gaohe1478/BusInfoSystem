using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket1.Model1;

namespace Ticket1
{
    public partial class dingpiao : Form
    {
        public dingpiao()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//QueryInfo()
        {
            using (busContext context = new busContext())
            {
                var re = context.Line.Join(context.Bookinfo, a => a.Lid, o => o.Lid, (a, o) => new { a.Mid0, a.Mid1, a.Mid2, a.Start, a.End, o.Lid, o.Bid, o.BusCode, o.StartTime, o.Usetime, o.Surplus, o.Price0, o.Price1, o.Price2, o.Price3 });
                string start1 = GetStart();
                string end1 = GetEnd();
                var list1 = re.Where(u => u.End == end1 && u.Start == start1).ToList();
                QueryInfo();
                //foreach (var temp in list1)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}

                //var list2 = re.Where(u => u.Mid0 == textBox2.Text && u.Start == textBox1.Text).ToList();
                //foreach (var temp in list2)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list3 = re.Where(u => u.Mid1 == textBox2.Text && u.Start == textBox1.Text).ToList();
                //foreach (var temp in list3)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list4 = re.Where(u => u.Mid2 == textBox2.Text && u.Start == textBox1.Text).ToList();
                //foreach (var temp in list4)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list5 = re.Where(u => u.Mid1 == textBox2.Text && u.Mid0 == textBox1.Text).ToList();
                //foreach (var temp in list5)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list6 = re.Where(u => u.Mid2 == textBox2.Text && u.Mid0 == textBox1.Text).ToList();
                //foreach (var temp in list6)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list7 = re.Where(u => u.End == textBox2.Text && u.Mid0 == textBox1.Text).ToList();
                //foreach (var temp in list7)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}

                //var list8 = re.Where(u => u.Mid2 == textBox2.Text && u.Mid1 == textBox1.Text).ToList();
                //foreach (var temp in list8)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list9 = re.Where(u => u.End == textBox2.Text && u.Mid1 == textBox1.Text).ToList();
                //foreach (var temp in list9)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
                //var list10 = re.Where(u => u.End == textBox2.Text && u.Mid2 == textBox1.Text).ToList();
                //foreach (var temp in list10)
                //{
                //    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                //    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                //    ListViewItem item = new ListViewItem();
                //    item.Text = temp.Bid;
                //    item.SubItems.Add(line.Start);
                //    item.SubItems.Add(line.Mid0);
                //    item.SubItems.Add(line.Mid1);
                //    item.SubItems.Add(line.Mid2);
                //    item.SubItems.Add(line.End);
                //    item.SubItems.Add(bus.BusCode);
                //    item.SubItems.Add(bus.Type);
                //    item.SubItems.Add(temp.StartTime);
                //    item.SubItems.Add(Convert.ToString(temp.Surplus));
                //    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                //    item.SubItems.Add(s);
                //    listView1.Items.Add(item);
                //}
            }
        }
        public void QueryInfo() {
            using (busContext context = new busContext()) {
                var re = context.Line.Join(context.Bookinfo, a => a.Lid, o => o.Lid, (a, o) => new { a.Mid0, a.Mid1, a.Mid2, a.Start, a.End, o.Lid, o.Bid, o.BusCode, o.StartTime, o.Usetime, o.Surplus, o.Price0, o.Price1, o.Price2, o.Price3 });
                var list1 = re.Where(u => u.End == textBox2.Text && u.Start == textBox1.Text).ToList();
                foreach (var temp in list1)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }

                var list2 = re.Where(u => u.Mid0 == textBox2.Text && u.Start == textBox1.Text).ToList();
                foreach (var temp in list2)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list3 = re.Where(u => u.Mid1 == textBox2.Text && u.Start == textBox1.Text).ToList();
                foreach (var temp in list3)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list4 = re.Where(u => u.Mid2 == textBox2.Text && u.Start == textBox1.Text).ToList();
                foreach (var temp in list4)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list5 = re.Where(u => u.Mid1 == textBox2.Text && u.Mid0 == textBox1.Text).ToList();
                foreach (var temp in list5)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list6 = re.Where(u => u.Mid2 == textBox2.Text && u.Mid0 == textBox1.Text).ToList();
                foreach (var temp in list6)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list7 = re.Where(u => u.End == textBox2.Text && u.Mid0 == textBox1.Text).ToList();
                foreach (var temp in list7)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }

                var list8 = re.Where(u => u.Mid2 == textBox2.Text && u.Mid1 == textBox1.Text).ToList();
                foreach (var temp in list8)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list9 = re.Where(u => u.End == textBox2.Text && u.Mid1 == textBox1.Text).ToList();
                foreach (var temp in list9)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
                var list10 = re.Where(u => u.End == textBox2.Text && u.Mid2 == textBox1.Text).ToList();
                foreach (var temp in list10)
                {
                    Line line = context.Line.FirstOrDefault(x => x.Lid == temp.Lid);
                    Bus bus = context.Bus.FirstOrDefault(x => x.BusCode == temp.BusCode);
                    ListViewItem item = new ListViewItem();
                    item.Text = temp.Bid;
                    item.SubItems.Add(line.Start);
                    item.SubItems.Add(line.Mid0);
                    item.SubItems.Add(line.Mid1);
                    item.SubItems.Add(line.Mid2);
                    item.SubItems.Add(line.End);
                    item.SubItems.Add(bus.BusCode);
                    item.SubItems.Add(bus.Type);
                    item.SubItems.Add(temp.StartTime);
                    item.SubItems.Add(Convert.ToString(temp.Surplus));
                    string s = string.Format("{0}{1}{2}{3}", temp.Price0 + "+", temp.Price1 + "+", temp.Price2 + "+", temp.Price3);
                    item.SubItems.Add(s);
                    listView1.Items.Add(item);
                }
            }
               
        }

        public string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)//RandomStr()
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }

        public string GetStart() {
            string start = textBox1.Text;
            return start;
        }
        public string GetEnd()
        {
            string end = textBox2.Text;
            return end;
        }

        private void Button2_Click(object sender, EventArgs e)//BuyTicketMe()
        {
            using (busContext context = new busContext())
            {
                var re = context.Line.Join(context.Bookinfo, a => a.Lid, o => o.Lid, (a, o) => new { a.Mid0, a.Mid1, a.Mid2, a.Start, a.End, o.Lid, o.Bid, o.BusCode, o.StartTime, o.Usetime, o.Surplus, o.Price0, o.Price1, o.Price2, o.Price3 });
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i];
                    Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(q => q.Bid == item.Text);
                    Line line = context.Line.FirstOrDefault(z=>z.Lid == bookinfo.Lid);

                    int price = Price(bookinfo,line);//int x=0,y=0,price=0;
                    //if (textBox1.Text == line.Start) x = 1;
                    //if (textBox1.Text == line.Mid0) x = 2;
                    //if (textBox1.Text == line.Mid1) x = 3;
                    //if (textBox1.Text == line.Mid2) x = 4;
                    //if (textBox2.Text == line.Mid0) y = 2;
                    //if (textBox2.Text == line.Mid1) y = 3;
                    //if (textBox2.Text == line.Mid2) y = 4;
                    //if (textBox2.Text == line.End) y = 5;
                    //int[] p= { 0,0,0,0};
                    //p[0] = int.Parse(bookinfo.Price0);
                    //p[1] = int.Parse(bookinfo.Price1);
                    //p[2] = int.Parse(bookinfo.Price2);
                    //p[3] = int.Parse(bookinfo.Price3);
                    //while (x < y) {
                    //    price += p[x-1];
                    //    x++;
                    //}

                    DialogResult result = MessageBox.Show("确定购买本线路车票？" + Environment.NewLine+"出发地："+textBox1.Text+Environment.NewLine+"目的地："+textBox2.Text+Environment.NewLine+"价格："+price, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (bookinfo.Surplus > 0)
                        {
                            Ticket ticket = new Ticket();
                            User temp = context.User.FirstOrDefault(a => a.Uid == "22222");
                            Bus temp1 = context.Bus.FirstOrDefault(a => a.BusCode == bookinfo.BusCode);
                            //ticket.Tid = GetRandomString(12, true, true, true, false, "Tk");
                            //ticket.Uid = temp.Uid;
                            //ticket.Bid = bookinfo.Bid;
                            //ticket.creattime = DateTime.Now.ToString();
                            //ticket.UserName = temp.Name;
                            //ticket.UserIdCode = int.Parse(temp.IdCode);
                            //ticket.Start = textBox1.Text;
                            //ticket.BusCode = temp1.BusCode;
                            //ticket.End = textBox2.Text;
                            //ticket.StartTime = bookinfo.StartTime;
                            //ticket.Price = Convert.ToString(price);
                            ticket = CreatTicket(temp, temp1, bookinfo, price);
                            context.Ticket.Add(ticket);
                            bookinfo.Surplus--;
                            context.SaveChanges();
                            MessageBox.Show("购买成功！", "提示");
                            
                        }
                        else {
                            MessageBox.Show("票已售完！", "提示");
                        }
                        



                        

                    }
                }
                    
            }
                
        }
        public Ticket CreatTicket(User temp,Bus temp1,Bookinfo bookinfo,int price) {
            Ticket ticket = new Ticket();
            ticket.Tid = GetRandomString(12, true, true, true, false, "Tk");
            ticket.Uid = temp.Uid;
            ticket.Bid = bookinfo.Bid;
            ticket.creattime = DateTime.Now.ToString();
            ticket.UserName = temp.Name;
            ticket.UserIdCode = temp.IdCode;
            ticket.Start = textBox1.Text;
            ticket.BusCode = temp1.BusCode;
            ticket.End = textBox2.Text;
            ticket.StartTime = bookinfo.StartTime;
            ticket.Price = Convert.ToString(price);
            return ticket;
        }

        public int Price(Bookinfo bookinfo,Line line) {
            int x = 0, y = 0, price = 0;
            if (textBox1.Text == line.Start) x = 1;
            if (textBox1.Text == line.Mid0) x = 2;
            if (textBox1.Text == line.Mid1) x = 3;
            if (textBox1.Text == line.Mid2) x = 4;
            if (textBox2.Text == line.Mid0) y = 2;
            if (textBox2.Text == line.Mid1) y = 3;
            if (textBox2.Text == line.Mid2) y = 4;
            if (textBox2.Text == line.End) y = 5;
            int[] p = { 0, 0, 0, 0 };
            p[0] = int.Parse(bookinfo.Price0);
            p[1] = int.Parse(bookinfo.Price1);
            p[2] = int.Parse(bookinfo.Price2);
            p[3] = int.Parse(bookinfo.Price3);
            while (x < y)
            {
                price += p[x - 1];
                x++;
            }
            return price;
        }


        private void Button3_Click(object sender, EventArgs e)//BuyTicketHe()
        {
            using (busContext context = new busContext())
            {
                var re = context.Line.Join(context.Bookinfo, a => a.Lid, o => o.Lid, (a, o) => new { a.Mid0, a.Mid1, a.Mid2, a.Start, a.End, o.Lid, o.Bid, o.BusCode, o.StartTime, o.Usetime, o.Surplus, o.Price0, o.Price1, o.Price2, o.Price3 });
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i];
                    Bookinfo bookinfo = context.Bookinfo.FirstOrDefault(q => q.Bid == item.Text);
                    Line line = context.Line.FirstOrDefault(z => z.Lid == bookinfo.Lid);
                    int x = 0, y = 0, price = 0;
                    if (textBox1.Text == line.Start) x = 1;
                    if (textBox1.Text == line.Mid0) x = 2;
                    if (textBox1.Text == line.Mid1) x = 3;
                    if (textBox1.Text == line.Mid2) x = 4;
                    if (textBox2.Text == line.Mid0) y = 2;
                    if (textBox2.Text == line.Mid1) y = 3;
                    if (textBox2.Text == line.Mid2) y = 4;
                    if (textBox2.Text == line.End) y = 5;
                    int[] p = { 0, 0, 0, 0 };
                    p[0] = int.Parse(bookinfo.Price0);
                    p[1] = int.Parse(bookinfo.Price1);
                    p[2] = int.Parse(bookinfo.Price2);
                    p[3] = int.Parse(bookinfo.Price3);
                    while (x < y)
                    {
                        price += p[x - 1];
                        x++;
                    }

                    DialogResult result = MessageBox.Show("确定购买本线路车票？" + Environment.NewLine + "出发地：" + textBox1.Text + Environment.NewLine + "目的地：" + textBox2.Text + Environment.NewLine + "价格：" + price+ Environment.NewLine+"购票人姓名："+textBox3.Text+ Environment.NewLine+"身份证号码："+textBox4.Text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (bookinfo.Surplus > 0)
                        {
                            Ticket ticket = new Ticket();
                            User temp = context.User.FirstOrDefault(a => a.Uid == "22221");
                            ticket.Tid = GetRandomString(12, true, true, true, false, "Tk");
                            ticket.Uid = temp.Uid;
                            ticket.Bid = bookinfo.Bid;
                            ticket.creattime = DateTime.Now.ToString();
                            ticket.UserName = textBox3.Text;
                            ticket.UserIdCode = textBox4.Text;
                            ticket.Start = textBox1.Text;
                            ticket.End = textBox2.Text;
                            ticket.StartTime = bookinfo.StartTime;
                            ticket.Price = Convert.ToString(price);
                            context.Ticket.Add(ticket);
                            bookinfo.Surplus--;
                            context.SaveChanges();
                            MessageBox.Show("购买成功！", "提示");

                        }
                        else
                        {
                            MessageBox.Show("票已售完！", "提示");
                        }






                    }
                }

            }

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dingpiao_Load(object sender, EventArgs e)
        {

        }
    }
}




