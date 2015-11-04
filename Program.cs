using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace PassSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool onlyInstance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mutex mtx = new Mutex(true, "PassSaver", out onlyInstance);
            if (onlyInstance)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Приложение уже запущено","Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
