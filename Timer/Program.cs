using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Timer
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
            Form1 app = new Form1();
            app.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(app);
        }
    }
}
