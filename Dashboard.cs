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
using System.Management;

namespace MEOsys
{
    public partial class Dashboard : Form
    {
       
        public Dashboard(string name, string level, string simplemode,string id)
        {
            InitializeComponent();
            lblname.Text = name;
            lbllevel.Text = SetUserLevel(level);
            this.simplemode = simplemode;
            this.id = id;
            cardModePanel.Dock = DockStyle.Fill;
            if (simplemode.Equals("1")) {
                simpleModeToolStripMenuItem.Checked = true;
            }
            else
                simpleModeToolStripMenuItem.Checked = false;



        }
        string simplemode;
        string id;


        int offset = 0;
        int limit = 0;
        Database db = new Database();
        Database db1 = new Database();
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            offset = 0;
            setdata();
            test();

        }
        void setdata() {

            dataGridViewAvailableData.DataSource = db.getData("((SELECT clients.first_name AS 'First Name',clients.last_name AS 'Last Name', building_permit.permit_number AS 'Building Permit', electrical_permit1.electrical_permit_number AS 'Electrical Permit', building_permit.location AS 'Location' FROM `clients` RIGHT JOIN `building_permit`  ON clients.client_id=building_permit.owner_id RIGHT JOIN `electrical_permit1` ON building_permit.owner_id = electrical_permit1.owner_id AND building_permit.permit_number=electrical_permit1.permit_number WHERE CONCAT (last_name,first_name,electrical_permit1.electrical_permit_number) LIKE '%" + textBox1.Text + "%'  ) UNION (SELECT  clients.first_name AS 'First Name',clients.last_name AS 'Last Name', building_permit.permit_number AS 'Building Permit', electrical_permit1.permit_number AS 'Electrical Permit', building_permit.location AS 'Location' FROM `clients` RIGHT JOIN `building_permit`  ON clients.client_id = building_permit.owner_id LEFT JOIN `electrical_permit1` ON building_permit.owner_id = electrical_permit1.owner_id AND building_permit.permit_number = electrical_permit1.electrical_permit_number  WHERE CONCAT (last_name,first_name,building_permit.permit_number) LIKE '%" + textBox1.Text + "%' )) LIMIT " + offset + "," + limit + " ;");

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            simpleModePanel.Dock = DockStyle.Fill;
            if (simpleModeToolStripMenuItem.Checked)
                panel1.Controls.Add(simpleModePanel);
            else
                panel1.Controls.Add(cardModePanel);
            limit = 100;
            offset = 0;
            dataGridViewAvailableData.DataSource = db.getData("((SELECT clients.first_name AS 'First Name',clients.last_name AS 'Last Name', building_permit.permit_number AS 'Building Permit', electrical_permit1.electrical_permit_number AS 'Electrical Permit', building_permit.location AS 'Location' FROM `clients` RIGHT JOIN `building_permit`  ON clients.client_id=building_permit.owner_id RIGHT JOIN `electrical_permit1` ON building_permit.owner_id = electrical_permit1.owner_id AND building_permit.permit_number=electrical_permit1.permit_number WHERE CONCAT (last_name,first_name) LIKE '%" + "" + "%'  ) UNION (SELECT  clients.first_name AS 'First Name',clients.last_name AS 'Last Name', building_permit.permit_number AS 'Building Permit', electrical_permit1.permit_number AS 'Electrical Permit', building_permit.location AS 'Location' FROM `clients` RIGHT JOIN `building_permit`  ON clients.client_id = building_permit.owner_id LEFT JOIN `electrical_permit1` ON building_permit.owner_id = electrical_permit1.owner_id AND building_permit.permit_number = electrical_permit1.electrical_permit_number  WHERE CONCAT (last_name,first_name) LIKE '%" + "" + "%' )) LIMIT "+offset+","+limit+" ;");
            timer1.Start();
            lbltime.Text = DateTime.Now.ToString("hh:mm tt");
            lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            test();
        }
            int sep = 1;
        void test() {

            MySqlDataReader r = db.editData("SELECT * FROM clients WHERE CONCAT (last_name,middle_name,first_name) LIKE '%" + textBox1.Text + "%' LIMIT " + offset + "," + limit + " ;");
            cardModePanel.Controls.Clear();
            int y = 0;
            sep = 1;
            while (r.Read())
            {
                DataTable tab = db1.getData("SELECT building_permit.permit_number FROM building_permit WHERE owner_id='"+ r.GetValue(0).ToString() + "' UNION SELECT electrical_permit1.electrical_permit_number FROM electrical_permit1 WHERE owner_id='" + r.GetValue(0).ToString() + "' ");
                UserControl content = new UserControl1(r.GetValue(0).ToString(), r.GetValue(1).ToString() + " " + r.GetValue(2).ToString() + ". " + r.GetValue(3).ToString(), r.GetValue(4).ToString(), tab.Rows.Count+"");

                if (sep % 2 == 1)
                    content.Location = new Point(10, 10 + (y));
                else
                {
                    content.Location = new Point((cardModePanel.Width ) / 2 +5, 10 + (y));

                    y += 90;
                }
                sep++;
                content.Size = new Size((cardModePanel.Width-50)/2,80);
                cardModePanel.Controls.Add(content);
            }
            r.Close();

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsForm frm = new clientsForm();
            frm.Show();

            frm.FormClosing += Form102_FormClosing;
        }

        private void electricalPermitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (electricalPermitToolStripMenuItem1.Checked)
                electricalPermitToolStripMenuItem1.Checked = false;
            else
                electricalPermitToolStripMenuItem1.Checked = true;
        }

        private void buildingPermitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (buildingPermitToolStripMenuItem1.Checked)
                buildingPermitToolStripMenuItem1.Checked = false;
            else
                buildingPermitToolStripMenuItem1.Checked = true;

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void resedentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resedentialToolStripMenuItem.Checked)
                resedentialToolStripMenuItem.Checked = false;
            else
                resedentialToolStripMenuItem.Checked = true;
        }

        private void commercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (commercialToolStripMenuItem.Checked)
                commercialToolStripMenuItem.Checked = false;
            else
                commercialToolStripMenuItem.Checked = true;
        }

      
        private void dataGridViewAvailableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAvailableData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIndex = (e.RowIndex + 1+offset).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dataGridViewAvailableData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 3)
            {
                if (dataGridViewAvailableData.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("")) {
                    return;
                }
                string id = db.getOneData("SELECT owner_id FROM building_permit WHERE permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                string location = db.getOneData("SELECT location FROM building_permit WHERE permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + id + "'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
                string date = DateTime.Parse(db.getOneData("SELECT date_issued FROM electrical_permit1 WHERE electrical_permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[3].Value.ToString() + "'")).ToString("yyyy-MM-dd");

                documentViewer docs = new documentViewer(fname, mname, lname, dataGridViewAvailableData.Rows[e.RowIndex].Cells[3].Value.ToString(), address, location, date);
                docs.Show();
            }
            else if (e.ColumnIndex == 2) {

                string id = db.getOneData("SELECT owner_id FROM building_permit WHERE permit_number = '"+dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString()+"'");
                string location = db.getOneData("SELECT location FROM building_permit WHERE permit_number = '"+dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString()+"'");
                string fname = db.getOneData("SELECT first_name from clients where client_id='" + id+"'");
                string mname = db.getOneData("SELECT middle_name from clients where client_id='" + id + "'");
                string lname = db.getOneData("SELECT last_name from clients where client_id='" + id + "'");
                string address = db.getOneData("SELECT address from clients where client_id='" + id + "'");
                string date = DateTime.Parse( db.getOneData("SELECT date_issued FROM building_permit WHERE permit_number = '" + dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value.ToString() + "'")).ToString("yyyy-MM-dd");
                 
                documentViewer docs = new documentViewer(fname, mname, lname, dataGridViewAvailableData.Rows[e.RowIndex].Cells[2].Value .ToString(), address, location,date, 1);
                docs.Show();
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            this.lbltime.Text = dt.ToString("hh:mm tt");
        }

        private void btnEP_Click(object sender, EventArgs e)
        {
            
            createElectricalPermit frm = new createElectricalPermit();
           
            frm.Show();
            frm.FormClosing += Form102_FormClosing;
        }
        private void Form102_FormClosing(object sender, FormClosingEventArgs e)
        {

            dataGridViewAvailableData.DataSource = db.getData("(SELECT clients.first_name AS 'First Name',clients.last_name AS 'Last Name', building_permit.permit_number AS 'Building Permit', electrical_permit1.electrical_permit_number AS 'Electrical Permit', building_permit.location AS 'Location' FROM `clients` RIGHT JOIN `building_permit`  ON clients.client_id=building_permit.owner_id RIGHT JOIN `electrical_permit1` ON building_permit.owner_id = electrical_permit1.owner_id AND building_permit.permit_number=electrical_permit1.permit_number WHERE CONCAT (last_name,first_name) LIKE '%" + "" + "%'  ) UNION (SELECT  clients.first_name AS 'First Name',clients.last_name AS 'Last Name', building_permit.permit_number AS 'Building Permit', electrical_permit1.permit_number AS 'Electrical Permit', building_permit.location AS 'Location' FROM `clients` RIGHT JOIN `building_permit`  ON clients.client_id = building_permit.owner_id LEFT JOIN `electrical_permit1` ON building_permit.owner_id = electrical_permit1.owner_id AND building_permit.permit_number = electrical_permit1.electrical_permit_number  WHERE CONCAT (last_name,first_name) LIKE '%" + "" + "%' ) ;");
            test();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
           
            clientsForm frm = new clientsForm();
            frm.Show();
            frm.FormClosing += Form102_FormClosing;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            createBuildingPermit frm = new createBuildingPermit();
            frm.Show();
            frm.FormClosing += Form102_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (simpleModeToolStripMenuItem.Checked)
            {
                if (dataGridViewAvailableData.RowCount < limit)
                {
                    MessageBox.Show("Already in last page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                offset += limit;
                setdata();
            }
            else {
                if (sep < limit) {
                    MessageBox.Show("Already in last page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                offset += limit;
                test();
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (simpleModeToolStripMenuItem.Checked)
            {
                if (offset < limit)
                {
                    if (offset == 0)
                        MessageBox.Show("Already in first page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    offset = 0;
                    return;
                }
                offset -= limit;
                setdata();
            }
            else
            {
                if (offset < limit)
                {
                    if (offset == 0)
                        MessageBox.Show("Already in first page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    offset = 0;
                    return;
                }
                offset -= limit;
                test();

            }
        }

        private void simpleModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            offset = 0;
            if (simpleModeToolStripMenuItem.Checked)
                simpleModeToolStripMenuItem.Checked = false;
            else
                simpleModeToolStripMenuItem.Checked = true;

            panel1.Controls.Clear();
            simpleModePanel.Dock = DockStyle.Fill;
            cardModePanel.Dock = DockStyle.Fill;
            if (simpleModeToolStripMenuItem.Checked)
                panel1.Controls.Add(simpleModePanel);
            else
                panel1.Controls.Add(cardModePanel);

            //update
            if(simpleModeToolStripMenuItem.Checked)
                db.updateData("UPDATE `users` SET `simple_mode` = '1' WHERE `users`.`id` = '"+id+"';");
            else
                db.updateData("UPDATE `users` SET `simple_mode` = '0' WHERE `users`.`id` = '" + id + "';");
        }

        private void cardModePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
