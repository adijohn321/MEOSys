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
    public partial class UCElectrical : UserControl
    {
        public UCElectrical()
        {
            InitializeComponent();
        }
        public UCElectrical(string permitNumber, string permitLocation, string permitDate, string id)
        {
            InitializeComponent();
            this.permitNumber = permitNumber;
            this.permitLocation = permitLocation;
            this.permitDate = permitDate;
            this.id = id;

            number.Text = permitNumber;
            created.Text = permitDate;
        }


        string permitNumber;
        string permitLocation;
        string permitDate;
        string id;
        Database db = new Database();
        void action()
        {
            string location = permitLocation;
            string fname = db.getOneData("SELECT first_name from clients where client_id='" + id + "'");
            string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
            string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
            string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
            string date = permitDate.Substring(0, 10);

            documentViewer docs = new documentViewer(fname, mname, lname, permitNumber, address, location, date);
            docs.Show();
        }


            public UCElectrical(string permitNumber, string date)
        {
            InitializeComponent();
            number.Text = permitNumber;
            created.Text = date;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {
            action();
        }
    }
}
