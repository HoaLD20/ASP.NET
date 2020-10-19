using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
namespace P5WF
{
    public partial class NDTForm : DevExpress.XtraEditors.XtraForm
    {
        public NDTForm()
        {
            InitializeComponent();
        }
        EntityMeow db;
        private void NDTForm_Load(object sender, EventArgs e)
        {
            db = new EntityMeow();
            db.nganhdts.Load();
            nganhdtBindingSource.DataSource = db.nganhdts.Local;
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nganhdtBindingSource.AddNew();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nganhdtBindingSource.RemoveCurrent();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Your data has been successfull save", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        struct NganhDTParameter
        {
            public List<nganhdt> ListNganhDT;
            public string fileName { get; set; }
        }
        NganhDTParameter _intputNganhDTParameter;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel|*.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                   
                    _intputNganhDTParameter.fileName = sfd.FileName;
                    _intputNganhDTParameter.ListNganhDT = db.nganhdts.ToList() as List<nganhdt>;
                    backgroundWorker1.RunWorkerAsync(_intputNganhDTParameter);
                }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<nganhdt> list = ((NganhDTParameter)e.Argument).ListNganhDT;
            Console.WriteLine(list.Count);

            string fileName = ((NganhDTParameter)e.Argument).fileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = list.Count;

            ws.Cells[index, 1] = "MaNganh";
            ws.Cells[index, 2] = "IDBDT";
            ws.Cells[index, 3] = "TenNganh";

            foreach (nganhdt nganh in list)
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = nganh.MaNganh;
                    ws.Cells[index, 2] = nganh.IDBDT;
                    ws.Cells[index, 3] = nganh.TenNganh;
                    
                }
            }

            ws.SaveAs(fileName, XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, false, XlSaveAsAccessMode.xlExclusive, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);


            wb.Close(true, Type.Missing, Type.Missing);
            excel.Quit();

            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(excel);
        }
    }
}