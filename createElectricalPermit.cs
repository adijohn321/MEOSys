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
    public partial class createElectricalPermit : Form
    {
        public createElectricalPermit()
        {
            InitializeComponent();
        }

        private void createElectricalPermit_Load(object sender, EventArgs e)
        {
            loadPermits("");
            createPermitNumber();

        }
        string owner;
        void setData(string id) {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("Select * from building_permit where permit_number = '"+id+"'", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                owner = dr.GetString("owner_id").ToString();
                textBoxClient.Text = (db.getOneData("SELECT first_name from clients where client_id='"+owner+"'")+" "+ db.getOneData("SELECT middle_name from clients where client_id='" + owner + "'")+" "+ db.getOneData("SELECT last_name from clients where client_id='" + owner + "'"));
                textBoxLocation.Text = dr.GetString("location").ToString();
            }


            dr.Close();
            conn.Close();

        }
        void loadPermits(string sear) {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("Select * from building_permit WHERE CONCAT(permit_number) LIKE '%"+sear+"%'", conn);
            dr = cmd.ExecuteReader();
            comboBoxBuildingPermit.Items.Clear();

            while (dr.Read())
            {
                comboBoxBuildingPermit.Items.Add(dr.GetString("permit_number").ToString());
            }


            dr.Close();
            conn.Close();

        }

        Database db = new Database();
        public MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=meosys;");
        public MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataReader dr1;
        MySqlDataReader dr2;





        void createPermitNumber()
        {

            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("Select * from `electrical_permit1`", conn);
            dr1 = cmd.ExecuteReader();
            string date = DateTime.Now.ToString("yyyy-MM"), date1 = date;
            int num = 0;
            while (dr1.Read())
            {
                num = Int32.Parse(dr1.GetString("electrical_permit_number").ToString().Substring(10, 4));
                date1 = dr1.GetString("electrical_permit_number").ToString().Substring(0, 7);
            }
            if (!(date.Substring(0, 4).Equals(date1.Substring(0, 4))))
                num = 0;
            textBoxPermitNumber.Text = date + "EP-" + numberToString(num) + (radioButton1.Checked ? "-R" : "-C");


            dr1.Close();
            conn.Close();
        }
        string numberToString(int input)
        {
            if (input > 10000)
            {
                return "0001";
            }
            input++;
            string output = "0000000" + input;


            return output.Substring(output.Length - 4, 4);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPermitNumber.Text = textBoxPermitNumber.Text.Substring(0, textBoxPermitNumber.Text.Length - 1) + (radioButton1.Checked ? "R" : "C");
        }

        private void comboBoxBuildingPermit_SelectedIndexChanged(object sender, EventArgs e)
        {
            setData(comboBoxBuildingPermit.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "'");
                string location = comboBoxLocation.SelectedItem.ToString();

                if (db.insertData("INSERT INTO `electrical_permit1`(`electrical_permit_number`, `permit_number`, `owner_id`, `date_issued`,`location`) VALUES ('" + textBoxPermitNumber.Text + "','none','" + (comboBoxClents.SelectedItem.ToString().Substring(1, comboBoxClents.SelectedItem.ToString().IndexOf(")") - 1)) + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','"+location+"')"))
                {


                    documentViewer docs = new documentViewer(fname, mname, lname, textBoxPermitNumber.Text, address, location, DateTime.Now.ToString("yyyy-MM-dd"));
                    docs.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error saving data.");
                }

            }
            else
            {
                string id = db.getOneData("SELECT owner_id FROM building_permit WHERE permit_number='" + comboBoxBuildingPermit.SelectedItem + "'");
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + id + "'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
                string location = db.getOneData("SELECT location FROM building_permit WHERE permit_number='" + comboBoxBuildingPermit.SelectedItem + "'");

                if (db.insertData("INSERT INTO `electrical_permit1`(`electrical_permit_number`, `permit_number`, `owner_id`, `date_issued`) VALUES ('" + textBoxPermitNumber.Text + "','" + comboBoxBuildingPermit.SelectedItem + "','" + id + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')"))
                {


                    documentViewer docs = new documentViewer(fname, mname, lname, textBoxPermitNumber.Text, address, location, DateTime.Now.ToString("yyyy-MM-dd"));
                    docs.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error saving data.");
                }
            }

        }

        private void comboBoxBuildingPermit_DropDown(object sender, EventArgs e)
        {
            loadPermits(comboBoxBuildingPermit.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBoxBuildingPermit.Text = "null";
                loadNames("");
                comboBoxClents.Visible = true;
                textBoxClient.Visible = false;
                textBoxLocation.Visible = false;
                comboBoxBuildingPermit.Enabled = false;
                comboBoxLocation.Visible = true;
            }
            else {
                comboBoxClents.Visible = false;
                textBoxClient.Visible = true;
                comboBoxLocation.Visible = false;
                textBoxLocation.Visible = true;
                comboBoxBuildingPermit.Enabled = true;
                comboBoxBuildingPermit.Text = "";
            }
        }


        void loadNames(string sear)
        {

            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("Select * from clients WHERE CONCAT(client_id,first_name,middle_name,last_name)LIKE '%" + sear + "%'", conn);
            dr2 = cmd.ExecuteReader();
            comboBoxClents.Items.Clear();

            while (dr2.Read())
            {
                comboBoxClents.Items.Add("(" + dr2.GetString("client_id").ToString() + ")" + dr2.GetString("first_name").ToString() + " " + dr2.GetString("middle_name").ToString() + ". " + dr2.GetString("last_name").ToString());
            }


            dr2.Close();
            conn.Close();
        }

        private void comboBoxClents_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxClents_DropDown(object sender, EventArgs e)
        {
            loadNames(comboBoxClents.Text);

        }
    }
}
