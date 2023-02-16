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
    public partial class ShowMore : Form
    {
        public ShowMore(string permitNumber ,string permitLocation, string id)
        {
            InitializeComponent();
            this.permitNumber = permitNumber;
            this.permitLocation = permitLocation;
            this.id = id;







            test2();
        }
        public ShowMore(string permitNumber, string permitLocation, string permitDate, string id)
        {
            InitializeComponent();
            this.permitNumber = permitNumber;
            this.permitLocation = permitLocation;
            this.permitDate = permitDate;
            this.id = id;
            number.Text = "Permit number: " + permitNumber;
            date.Text = "Date issued: " + permitDate.Substring(0, 10);
            location.Text = "Location: " + permitLocation;
            test2();

        }
        string permitNumber;
        string permitLocation;
        string permitDate;
        string id;


        private void ShowMore_Load(object sender, EventArgs e)
        {

        }

        Database db1 = new Database();
        int y = 0;
        int count = 0;
        void test2()
        {
            groupBox1.Text = permitNumber;
            MySqlDataReader r = db1.editData("SELECT * FROM electrical_permit1 WHERE permit_number='" + permitNumber + "'");
            while (r.Read())
            {
                count++;
                UserControl content = new UCElectrical(r.GetString(0), permitLocation, r.GetString(3).Substring(0, 10), id);
                content.Location = new Point(10, 20 + (y));
                content.Size = new Size(content.Width,content.Height+10);

                groupBox1.Controls.Add(content);
                y += content.Height + 5;
            }

            r.Close();

        }
    }
}
