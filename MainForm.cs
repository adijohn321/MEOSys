using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEOsys
{
    public partial class MainForm : Form
    {
        public MainForm(string name, string level)
        {
            InitializeComponent();
            lblname.Text = name;
            lbllevel.Text = SetUserLevel(level);
        }
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
        Microsoft.Office.Interop.Word.Application app;
        Microsoft.Office.Interop.Word.Document doc;
        object tmpFile = Environment.CurrentDirectory+"/templates/BuildingPermit.pdf";
        object objMissing = Missing.Value;
        object filelocation = Environment.CurrentDirectory + "/templates/BuildingPermit.docx";

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                app = new Microsoft.Office.Interop.Word.Application();
                
            }
            catch(Exception ex ) {
                MessageBox.Show(ex.Message);
            }

        }

        private void findAndReplace(object find, object replaceWith) {
            this.app.Selection.Find.Execute(ref find,true, true, false, false, false, true,false, 1, ref replaceWith, 2, false, false, false, false);
        }

        private void permitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.CurrentDirectory);

            findAndReplace("2022-04BP-001-R", "202R");

            doc.ExportAsFixedFormat(tmpFile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            this.PDFviewer.src = tmpFile.ToString();
            this.PDFviewer.Refresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                doc.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
                app.Quit(WdSaveOptions.wdDoNotSaveChanges);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            app = new Microsoft.Office.Interop.Word.Application();
            if(app.Documents.Count!=0)
                app.Documents.Close(WdSaveOptions.wdDoNotSaveChanges);
            doc = app.Documents.Open(ref filelocation, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing);
            findAndReplace("[firstname]", textBoxFirstName.Text.ToUpper());
            findAndReplace("[mi]", textBoxMiddleName.Text.ToUpper().Substring(0,1)+".");
            findAndReplace("[lastname]", textBoxLastName.Text.ToUpper());
            findAndReplace("[date]", DateTime.Now.ToString()) ;
            doc.ExportAsFixedFormat(tmpFile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            this.PDFviewer.src = tmpFile.ToString();
            this.PDFviewer.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PDFviewer.Print();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
