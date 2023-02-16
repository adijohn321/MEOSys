
namespace MEOsys
{
    partial class UCPermits
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showMore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.location);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.number);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(392, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MEOsys.Properties.Resources.building;
            this.pictureBox1.Location = new System.Drawing.Point(9, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(69, 42);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(51, 13);
            this.location.TabIndex = 2;
            this.location.Text = "Location:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(69, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(73, 13);
            this.date.TabIndex = 1;
            this.date.Text = "Date Created:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(68, 9);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(132, 20);
            this.number.TabIndex = 0;
            this.number.Text = "Permit Number:";
            this.number.Click += new System.EventHandler(this.number_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Location = new System.Drawing.Point(25, 5);
            this.groupBox1.MaximumSize = new System.Drawing.Size(350, 1000);
            this.groupBox1.MinimumSize = new System.Drawing.Size(340, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 19);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Electrical Permits";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 67);
            this.panel2.MaximumSize = new System.Drawing.Size(400, 1400);
            this.panel2.MinimumSize = new System.Drawing.Size(350, 19);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(392, 32);
            this.panel2.TabIndex = 1;
            // 
            // showMore
            // 
            this.showMore.Location = new System.Drawing.Point(259, 19);
            this.showMore.Name = "showMore";
            this.showMore.Size = new System.Drawing.Size(75, 23);
            this.showMore.TabIndex = 0;
            this.showMore.Text = "Show All";
            this.showMore.UseVisualStyleBackColor = true;
            this.showMore.Visible = false;
            this.showMore.Click += new System.EventHandler(this.showMore_Click);
            // 
            // UCPermits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showMore);
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name = "UCPermits";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(402, 104);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showMore;
    }
}
