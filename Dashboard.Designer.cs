
namespace MEOsys
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricalPermitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingPermitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resedentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleModePanel = new System.Windows.Forms.Panel();
            this.dataGridViewAvailableData = new System.Windows.Forms.DataGridView();
            this.cardModePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbllevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbldate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnEP = new System.Windows.Forms.Button();
            this.btnBP = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.simpleModePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electricalPermitToolStripMenuItem1,
            this.buildingPermitToolStripMenuItem1,
            this.resedentialToolStripMenuItem,
            this.commercialToolStripMenuItem,
            this.simpleModeToolStripMenuItem});
            this.filtersToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // electricalPermitToolStripMenuItem1
            // 
            this.electricalPermitToolStripMenuItem1.Checked = true;
            this.electricalPermitToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.electricalPermitToolStripMenuItem1.Name = "electricalPermitToolStripMenuItem1";
            this.electricalPermitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.electricalPermitToolStripMenuItem1.Text = "Electrical Permit";
            this.electricalPermitToolStripMenuItem1.Click += new System.EventHandler(this.electricalPermitToolStripMenuItem1_Click);
            // 
            // buildingPermitToolStripMenuItem1
            // 
            this.buildingPermitToolStripMenuItem1.Checked = true;
            this.buildingPermitToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildingPermitToolStripMenuItem1.Name = "buildingPermitToolStripMenuItem1";
            this.buildingPermitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.buildingPermitToolStripMenuItem1.Text = "Building Permit";
            this.buildingPermitToolStripMenuItem1.Click += new System.EventHandler(this.buildingPermitToolStripMenuItem1_Click);
            // 
            // resedentialToolStripMenuItem
            // 
            this.resedentialToolStripMenuItem.Checked = true;
            this.resedentialToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resedentialToolStripMenuItem.Name = "resedentialToolStripMenuItem";
            this.resedentialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resedentialToolStripMenuItem.Text = "Resedential";
            this.resedentialToolStripMenuItem.Click += new System.EventHandler(this.resedentialToolStripMenuItem_Click);
            // 
            // commercialToolStripMenuItem
            // 
            this.commercialToolStripMenuItem.Checked = true;
            this.commercialToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commercialToolStripMenuItem.Name = "commercialToolStripMenuItem";
            this.commercialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commercialToolStripMenuItem.Text = "Commercial";
            this.commercialToolStripMenuItem.Click += new System.EventHandler(this.commercialToolStripMenuItem_Click);
            // 
            // simpleModeToolStripMenuItem
            // 
            this.simpleModeToolStripMenuItem.Checked = true;
            this.simpleModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simpleModeToolStripMenuItem.Name = "simpleModeToolStripMenuItem";
            this.simpleModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simpleModeToolStripMenuItem.Text = "Simple Mode";
            this.simpleModeToolStripMenuItem.Click += new System.EventHandler(this.simpleModeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.simpleModePanel);
            this.panel1.Controls.Add(this.cardModePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(318, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1022, 649);
            this.panel1.TabIndex = 2;
            // 
            // simpleModePanel
            // 
            this.simpleModePanel.Controls.Add(this.dataGridViewAvailableData);
            this.simpleModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleModePanel.Location = new System.Drawing.Point(3, 3);
            this.simpleModePanel.Name = "simpleModePanel";
            this.simpleModePanel.Size = new System.Drawing.Size(1016, 211);
            this.simpleModePanel.TabIndex = 13;
            // 
            // dataGridViewAvailableData
            // 
            this.dataGridViewAvailableData.AllowUserToAddRows = false;
            this.dataGridViewAvailableData.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvailableData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvailableData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAvailableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAvailableData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAvailableData.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAvailableData.Name = "dataGridViewAvailableData";
            this.dataGridViewAvailableData.ReadOnly = true;
            this.dataGridViewAvailableData.RowHeadersWidth = 62;
            this.dataGridViewAvailableData.RowTemplate.Height = 28;
            this.dataGridViewAvailableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableData.Size = new System.Drawing.Size(1016, 211);
            this.dataGridViewAvailableData.TabIndex = 11;
            this.dataGridViewAvailableData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvailableData_CellContentClick);
            this.dataGridViewAvailableData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAvailableData_CellMouseDoubleClick);
            this.dataGridViewAvailableData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewAvailableData_RowPostPaint);
            // 
            // cardModePanel
            // 
            this.cardModePanel.AutoScroll = true;
            this.cardModePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardModePanel.Location = new System.Drawing.Point(3, 214);
            this.cardModePanel.Name = "cardModePanel";
            this.cardModePanel.Size = new System.Drawing.Size(1016, 432);
            this.cardModePanel.TabIndex = 12;
            this.cardModePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cardModePanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1036, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblname,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lbllevel,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.lbldate,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel10,
            this.lbltime});
            this.statusStrip1.Location = new System.Drawing.Point(318, 749);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.TabStop = true;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Username:";
            // 
            // lblname
            // 
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(123, 17);
            this.lblname.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(167, 17);
            this.toolStripStatusLabel3.Text = "                                        ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel4.Text = "User Level:";
            // 
            // lbllevel
            // 
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(123, 17);
            this.lbllevel.Text = "toolStripStatusLabel5";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabel6.Text = "                                       ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel7.Text = "Date:";
            // 
            // lbldate
            // 
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(123, 17);
            this.lbldate.Text = "toolStripStatusLabel8";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(163, 14);
            this.toolStripStatusLabel9.Text = "                                       ";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(38, 14);
            this.toolStripStatusLabel10.Text = "Time:";
            // 
            // lbltime
            // 
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(42, 14);
            this.lbltime.Text = "lbltime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.btnPrevPage);
            this.panel3.Controls.Add(this.btnNextPage);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.title);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnClient);
            this.panel3.Controls.Add(this.btnEP);
            this.panel3.Controls.Add(this.btnBP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 771);
            this.panel3.TabIndex = 7;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrevPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.Location = new System.Drawing.Point(31, 524);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(231, 55);
            this.btnPrevPage.TabIndex = 10;
            this.btnPrevPage.Text = "Previous Page";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNextPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(31, 448);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(231, 55);
            this.btnNextPage.TabIndex = 9;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MEOsys.Properties.Resources.sultan_kudarat_municipal_logo_3d_by_manshurodasan_dakxmsl_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(89, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(292, 25);
            this.title.TabIndex = 4;
            this.title.Text = "Municipal Engineer System";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(31, 595);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(31, 370);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(231, 55);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnEP
            // 
            this.btnEP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEP.Location = new System.Drawing.Point(31, 291);
            this.btnEP.Name = "btnEP";
            this.btnEP.Size = new System.Drawing.Size(231, 55);
            this.btnEP.TabIndex = 0;
            this.btnEP.Text = "Electrical Permit";
            this.btnEP.UseVisualStyleBackColor = false;
            this.btnEP.Click += new System.EventHandler(this.btnEP_Click);
            // 
            // btnBP
            // 
            this.btnBP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBP.Location = new System.Drawing.Point(31, 215);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(231, 55);
            this.btnBP.TabIndex = 0;
            this.btnBP.Text = "Building Permit";
            this.btnBP.UseVisualStyleBackColor = false;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(318, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 100);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Typing Here";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 771);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.simpleModePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricalPermitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buildingPermitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resedentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commercialToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridViewAvailableData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbllevel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lbldate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnEP;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Panel cardModePanel;
        private System.Windows.Forms.Panel simpleModePanel;
        private System.Windows.Forms.ToolStripMenuItem simpleModeToolStripMenuItem;
    }
}