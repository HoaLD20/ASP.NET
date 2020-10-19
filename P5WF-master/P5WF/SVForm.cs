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

namespace P5WF
{
    public partial class SVForm : DevExpress.XtraEditors.XtraForm
    {
        public SVForm()
        {
            InitializeComponent();
        }
        EntityMeow db;
        private void SVForm_Load(object sender, EventArgs e)
        {
            db = new EntityMeow();
            db.sinh_vien.Load();
            sinhvienBindingSource.DataSource = db.sinh_vien.Local;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sinhvienBindingSource.AddNew();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sinhvienBindingSource.RemoveCurrent();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}