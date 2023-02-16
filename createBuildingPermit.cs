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
    public partial class createBuildingPermit : Form
    {
        public createBuildingPermit()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createBuildingPermit_Load(object sender, EventArgs e)
        {
            loadNames("");
            createPermitNumber();

        }
        void createPermitNumber() {

            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("Select * from building_permit", conn);
            dr1 = cmd.ExecuteReader();
            string date = DateTime.Now.ToString("yyyy-MM"),date1 = date;
            int num = 0;
            while (dr1.Read()) {
                num =Int32.Parse(dr1.GetString("permit_number").ToString().Substring(10, 4));
                date1 = dr1.GetString("permit_number").ToString().Substring(0, 7);
            }
            if (!(date.Substring(0,4).Equals(date1.Substring(0,4))))
                num = 0;
            txtPermitNumber.Text = date + "BP-" + numberToString(num) +(radioButton1.Checked?"-R":"-C");


            dr1.Close();
            conn.Close();
        }
        string numberToString(int input) {
            if (input > 10000) {
                return "0001";
            }
            input++;
            string output = "0000000" + input;


            return output.Substring(output.Length-4,4);
        }

        void loadNames(string sear) {

            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("Select * from clients WHERE CONCAT(client_id,first_name,middle_name,last_name)LIKE '%"+sear+"%'", conn);
            dr = cmd.ExecuteReader();
            comboBoxClents.Items.Clear();

            while (dr.Read())
            {
                comboBoxClents.Items.Add("("+dr.GetString("client_id").ToString()+")"+ dr.GetString("first_name").ToString()+" "+ dr.GetString("middle_name").ToString()+". "+ dr.GetString("last_name").ToString());
            }


            dr.Close();
            conn.Close();
        }

        Database db = new Database();
        public MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=meosys;");
        public MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataReader dr1;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPermitNumber.Text = txtPermitNumber.Text.Substring(0, txtPermitNumber.Text.Length - 1) + (radioButton1.Checked ? "R" : "C");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (db.insertData("INSERT INTO `building_permit`(`permit_number`, `owner_id`, `location`,`date_issued`) VALUES ('" + txtPermitNumber.Text + "','" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "','" + comboBoxLocation.SelectedItem + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')"))
            {
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");


                documentViewer docs = new documentViewer(fname,mname,lname,txtPermitNumber.Text, address, comboBoxLocation.SelectedItem.ToString(),DateTime.Now.ToString("yyyy-MM-dd"),1);
                docs.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Error saving data.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClents_DropDown(object sender, EventArgs e)
        {

            loadNames(comboBoxClents.Text);
        }
    }
}
