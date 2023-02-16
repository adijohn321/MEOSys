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
    public partial class UCPermits : UserControl
    {
        public UCPermits(string permitNumber, string permitLocation, string permitDate, string id)
        {
            InitializeComponent();
            this.permitNumber = permitNumber;
            this.permitLocation = permitLocation;
            this.permitDate = permitDate;
            this.id = id;
            number.Text = "Permit number: "+permitNumber;
            date.Text = "Date issued: "+permitDate.Substring(0,10);
            location.Text = "Location: "+permitLocation;
            test2();
            
        }
        string permitNumber;
        string permitLocation;
        string permitDate;
        string id;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Database db = new Database();
        void action() {
            string location = permitLocation;
            string fname = db.getOneData("SELECT first_name from clients where client_id='" + id + "'");
            string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
            string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
            string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
            string date = permitDate.Substring(0,10);

            documentViewer docs = new documentViewer(fname, mname, lname, permitNumber, address, location, date, 1);
            docs.Show();

            /*if (permitNumber.Contains("EP"))
            {
                string id = db.getOneData("SELECT owner_id FROM building_permit WHERE permit_number = '" + permitNumber + "'");
                string location = db.getOneData("SELECT location FROM building_permit WHERE permit_number = '" + permitNumber + "'");
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + id + "'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
                string date = DateTime.Parse(db.getOneData("SELECT date_issued FROM electrical_permit1 WHERE electrical_permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[3].Value.ToString() + "'")).ToString("yyyy-MM-dd");

                documentViewer docs = new documentViewer(fname, mname, lname, permitNumber, address, location, date);
                docs.Show();
            }
            else if (e.ColumnIndex == 2)
            {

                string id = db.getOneData("SELECT owner_id FROM building_permit WHERE permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                string location = db.getOneData("SELECT location FROM building_permit WHERE permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + id + "'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
                string date = DateTime.Parse(db.getOneData("SELECT date_issued FROM building_permit WHERE permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString() + "'")).ToString("yyyy-MM-dd");

                documentViewer docs = new documentViewer(fname, mname, lname, dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString(), address, location, date, 1);
                docs.Show();
            }*/


        }
        Database db1 = new Database();
            int y = 0;
            int count = 0;
        void test2()
        {
            MySqlDataReader r = db1.editData("SELECT * FROM electrical_permit1 WHERE permit_number='" + permitNumber + "' LIMIT 0,4");
            while (r.Read())
            {
                count++;
                UserControl content = new UCElectrical(r.GetString(0),permitLocation,r.GetString(3).Substring(0,10),id);
                content.Location = new Point(10, 20 + (y));

                groupBox1.Controls.Add(content);
                y += content.Height+5;
                if (count == 3&&r.Read()) {
                    showMore.Location = new Point(10,((20+y)));
                    showMore.Visible = true;
                    groupBox1.Controls.Add(showMore);
                    return;
                }
            }

            r.Close();

        }

        private void number_Click(object sender, EventArgs e)
        {
            action();
        }

        private void showMore_Click(object sender, EventArgs e)
        {
            new ShowMore(permitNumber,permitLocation,permitDate,id).Show();

        }
    }
}
