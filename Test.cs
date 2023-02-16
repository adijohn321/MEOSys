using MySql.Data.MySqlClient;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        public Test(string id, string name, string address)
        {
            InitializeComponent();  
            this.id = id;
            this.name = name;
            this.address = address;
            lblName.Text = name;
            lblAddress.Text =address+", Sultan Kudarat, Maguindanao";
            test();
            test2();
        }
        string id;
        string name;
        string address;

        private void Test_Load(object sender, EventArgs e)
        {
            this.Text = name+" Permit/s";
        }
        Database db = new Database();
        Database db1 = new Database();
        int y = 0;
        void test()
        {

            MySqlDataReader r = db.editData("SELECT * FROM building_permit WHERE owner_id='"+id+"'");
            group1.Controls.Clear();
            while (r.Read())
            {
                UserControl content = new UCPermits(r.GetValue(0).ToString(), r.GetValue(2).ToString(), r.GetValue(3).ToString(),id);
                content.Location = new Point(10, 20 + (y));

                group1.Controls.Add(content);
                y += (int) (content.Height*0.75);
            }
            r.Close();

        }
        void test2()
        {

            MySqlDataReader r = db1.editData("SELECT * FROM electrical_permit1 WHERE owner_id='" + id + "' AND permit_number='none'");
            while (r.Read())
            {
                UserControl content = new UCElectrical(r.GetValue(0).ToString(), r.GetValue(4).ToString(), r.GetValue(3).ToString(),id);
                content.Location = new Point(10, 20 + (y));

                group1.Controls.Add(content);
                y += (int)(content.Height * 0.75);
            }
            r.Close();

        }
    }
}
