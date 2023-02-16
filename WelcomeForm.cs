using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEOsys
{
    public partial class WelcomeForm : Form
    {
        string name, level;
        public WelcomeForm(string name, string level,string simplemode,string id)
        {
            InitializeComponent();
            this.name = name;
            this.level = level;
            lbllevel.Text = SetUserLevel(level);
            lblname.Text = name;
            this.simplemode = simplemode;
            this.id = id;
        }
        string simplemode;
        string id;

        private void btnproceed_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(name, level,simplemode,id);
            this.Hide();
            dashboard.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            this.lbltime.Text = dt.ToString("hh:mm tt");
        }

        private void btnsetdatetime_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process time = System.Diagnostics.Process.Start("timedate.cpl");
        }

        private void setDateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lbltime.Text = dateTime.ToString("hh:mm tt");
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbltime.Text = DateTime.Now.ToString("hh:mm tt");
            lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        public string SetUserLevel(string input)
        {
            switch (input)
            {
                case "1":
                    return "Administrator";
                case "0":
                    return "Clerk 1";
                default:
                    return "Invalid";
            }
        }
    }
}
