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
    public partial class clientsForm : Form
    {
        public clientsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.insertData("INSERT INTO `clients`(`client_id`, `first_name`, `middle_name`, `last_name`,`address`) VALUES (NULL,'" + txtfname.Text.ToUpper() + "','" + txtmname.Text.ToUpper() + "','" + txtlname.Text.ToUpper() + "','" + cbaddress.SelectedItem.ToString() + "')"))
                    MessageBox.Show("Data Successfully Added.");

                else
                    MessageBox.Show("Failed to add data.");
                RefreshData();
                txtfname.Text = "";
                txtmname.Text = "";
                txtlname.Text = "";
                cbaddress.SelectedIndex = -1;


            }
            catch (System.NullReferenceException ex) {
                MessageBox.Show("Invalid inputs");
            }

        }
        Database db = new Database();

        private void clientsForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData() {

            dataGridView1.DataSource = db.getData("SELECT * FROM `clients`");

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbaddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
