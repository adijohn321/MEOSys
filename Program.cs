using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEOsys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
/*
            ObjectQuery winQ = new ObjectQuery("SELECT * FROM Win32_LogicalMemoryConfiguration");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQ);
            ManagementObjectCollection results = searcher.Get();
            foreach (ManagementObject result in results)
            {
                MessageBox.Show("" + results["TotalVisibleMemorySize"]);
            }*/
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
    }
}
