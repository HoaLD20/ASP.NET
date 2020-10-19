using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using Org.BouncyCastle.Math.Field;
using System.Threading;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraExport.Implementation;
using Microsoft.Office.Interop.Excel;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using System.Runtime.InteropServices;

namespace P5WF
{
    public partial class BDTForm : DevExpress.XtraEditors.XtraForm
    {
        public BDTForm()
        {
            InitializeComponent();
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
            }

        }
        EntityMeow db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new EntityMeow();
            db.bacdts.Load();
            bacdtBindingSource.DataSource = db.bacdts.Local;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            List<bacdt> list = ((BatDTParameter)e.Argument).ListBatDT;

            string fileName = ((BatDTParameter)e.Argument).fileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = list.Count;

            ws.Cells[index, 1] = "IDBDT";
            ws.Cells[index, 2] = "TenBacDT";

            foreach (bacdt bac in list)
            {
                if (!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = bac.IDBDT;
                    ws.Cells[index, 2] = bac.TenBacDT;

                }
            }

            ws.SaveAs(fileName, XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, false, XlSaveAsAccessMode.xlExclusive, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);


            wb.Close(true, Type.Missing, Type.Missing);
            excel.Quit();

    
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bacdtBindingSource.AddNew();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bacdtBindingSource.RemoveCurrent();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool cellEmpty = false;
            int emptyRow = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "IDBDT") == null || gridView1.GetRowCellValue(i, "TenBacDT") == null)
                {
                    emptyRow = i + 1;
                    cellEmpty = true;
                    break;
                }
                else if (String.IsNullOrWhiteSpace(gridView1.GetRowCellValue(i, "IDBDT").ToString()) || String.IsNullOrWhiteSpace(gridView1.GetRowCellValue(i, "TenBacDT").ToString()))
                {
                    emptyRow = i + 1;
                    cellEmpty = true;
                    break;
                }
            }

            if (!cellEmpty)
            {
                db.SaveChanges();
                XtraMessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(string.Format("Row {0} data fields must not be empty!", emptyRow), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;

                }
            }
            bacdtBindingSource.ResetBindings(false);
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
        struct BatDTParameter
        {
            public List<bacdt> ListBatDT;
            public string fileName
            {
                get; set;
            }
        }
        BatDTParameter _intputbatDTParameter;


        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "|*.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    _intputbatDTParameter.fileName = sfd.FileName;
                    _intputbatDTParameter.ListBatDT = db.bacdts.ToList() as List<bacdt>;
                    backgroundWorker.RunWorkerAsync(_intputbatDTParameter);

                }
            }
        }

        private void progressBarControl1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bacdtBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
