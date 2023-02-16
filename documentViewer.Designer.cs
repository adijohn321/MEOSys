
namespace MEOsys
{
    partial class documentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(documentViewer));
            this.PDFviewer = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PDFviewer)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFviewer
            // 
            this.PDFviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFviewer.Enabled = true;
            this.PDFviewer.Location = new System.Drawing.Point(0, 0);
            this.PDFviewer.Name = "PDFviewer";
            this.PDFviewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFviewer.OcxState")));
            this.PDFviewer.Size = new System.Drawing.Size(1352, 792);
            this.PDFviewer.TabIndex = 2;
            // 
            // documentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 792);
            this.Controls.Add(this.PDFviewer);
            this.Name = "documentViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "documentViewer";
            this.Load += new System.EventHandler(this.documentViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFviewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDFviewer;
    }
}