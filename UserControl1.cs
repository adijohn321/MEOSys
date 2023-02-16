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
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string id, string name, string address,string no)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            this.address = address;
            label1.Text = name;
            label2.Text = address+", Sultan Kudarat, Maguindanao";
            label3.Text = "Total Permit/s: "+no;
        }
        string id = "";
        string address;
        string name;
        string no;

        private void label1_Click(object sender, EventArgs e)
        {
            new Test(id, name, address).Show();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            //dito ka mag add
            new Test(id,name,address).Show();

        }
    }
}
