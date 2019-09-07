using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LineMange());
            //Form1 form1 = new Form1();

            //form1.ShowDialog();

            //if (form1.DialogResult == DialogResult.OK)
            //{
            //    form1.Dispose();
            //    Application.Run(new AdminControl());
            //}
            //else {
            //    if (form1.DialogResult == DialogResult.No)
            //    {
            //        form1.Dispose();
            //        Application.Run(new UserControl());
            //    }
            //    else {
            //        form1.Dispose();
            //        return;
            //    }
            //}
        }
    }

    public class common
    {
        public static string id = "";
    }
}
