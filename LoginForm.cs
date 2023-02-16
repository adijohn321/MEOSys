using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEOsys
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        MySqlConnection con = new Database().getConnection();
        Database data = new Database();


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where username='" + txtusername.Text.Trim() + "' and password='" + txtPassword.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Incorect username and/or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPassword.Text = "";
                    txtusername.Text = "";
                }
                else
                {

                    MySqlDataReader reader = data.getUserLevel(txtusername.Text.Trim(), txtPassword.Text);
                    reader.Read();
                    WelcomeForm frm = new WelcomeForm(reader.GetValue(1).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(0).ToString());
                    data.closeConnection();
                    frm.Show();
                    this.Hide();

                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
