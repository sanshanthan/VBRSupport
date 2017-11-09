using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VBRSupport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Singleton<Login>.Instance);

            if (Singleton<Login>.Instance.IsLogin)
            {

                Application.Run(new Main());
            }

            //Application.Run(new Main());
        }
    }
}
