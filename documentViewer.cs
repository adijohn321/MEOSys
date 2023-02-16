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
using Vonage;

namespace MEOsys
{
    public partial class documentViewer : Form
    {
        public documentViewer()
        {
            InitializeComponent();
        }
        public documentViewer(string firstName, string mi, string lastName, string permitNumber, string address, string location,string date,int i)
        {

            InitializeComponent();
            this.firstName = firstName;
            this.mi = mi;
            this.lastName = lastName;
            this.permitNumber = permitNumber;
            this.location = location;
            this.address = address;
            this.date = date;

            tmpFile = Environment.CurrentDirectory + "/templates/BuildingPermit.pdf";
            filelocation = Environment.CurrentDirectory + "/templates/BuildingPermit.docx";

        }
        public documentViewer(string firstName, string mi, string lastName, string permitNumber, string address, string location,string date)
        {

            InitializeComponent();
            this.firstName = firstName;
            this.mi = mi;
            this.lastName = lastName;
            this.permitNumber = permitNumber;
            this.location = location;
            this.address = address;
            this.date = date;

            tmpFile = Environment.CurrentDirectory + "/templates/ElectricalPermit.pdf";
            filelocation = Environment.CurrentDirectory + "/templates/ElectricalPermit.docx";

        }

        Microsoft.Office.Interop.Word.Application app;
        Microsoft.Office.Interop.Word.Document doc;
        object objMissing = Missing.Value;
        object tmpFile;
        object filelocation;



        string firstName, mi, lastName;
        string permitNumber,location, address,date;


        private void documentViewer_Load(object sender, EventArgs e)
        {
            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                doc = app.Documents.Open(ref filelocation, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing);
                findAndReplace("[dateissued]", DateTime.Now.ToString("yyyy-MM-dd"));
                findAndReplace("[dateofapplication]", date);
                findAndReplace("[applicationno]", permitNumber);
                findAndReplace("[areano]", permitNumber);
                findAndReplace("[lastname]", lastName);
                findAndReplace("[firstname]", firstName);
                findAndReplace("[brgy]", address);
                findAndReplace("[locationofconstruction]", location);
                findAndReplace("[mi]", mi);

                doc.ExportAsFixedFormat(tmpFile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                this.PDFviewer.src = tmpFile.ToString();
                this.PDFviewer.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                doc.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
                app.Quit(WdSaveOptions.wdDoNotSaveChanges);
            }

        }
        private void findAndReplace(object find, object replaceWith)
        {
            this.app.Selection.Find.Execute(ref find, true, true, false, false, false, true, false, 1, ref replaceWith, 2, false, false, false, false);
        }
        public void buildingPermit() {


        
        }

        public void electricalPermit()
        {

        }
    }
}
