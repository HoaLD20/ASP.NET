using System;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMonHoc
{
    public partial class Edit : Form
    {
        Monhoc mh = new Monhoc();


        public Edit()
        {

           
            InitializeComponent();
        }


        public void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        


        public void save()
        {
            mh.IDMH = tbIDDDDDDDDDD.Text.Trim();
            mh.MA_HK = tbMMH.Text.Trim();
            mh.TenMH = tbMH.Text.Trim();
            mh.SoTC = Convert.ToInt32(tbTC.Text.Trim());
            mh.LyThuyet = Convert.ToInt32(tbLT.Text.Trim());
            mh.ThucHanh = Convert.ToInt32(tbTH.Text.Trim());
            //mh.ThucHanh = Convert.ToInt32(tbTH.Text.Trim());
            using (MonhocEntities db = new MonhocEntities())
            {
                db.Entry(mh).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            mh.IDMH = tbIDDDDDDDDDD.Text.Trim();
            mh.MA_HK = tbMMH.Text.Trim();
            mh.TenMH = tbMH.Text.Trim();
            mh.SoTC = Convert.ToInt32(tbTC.Text.Trim());
            mh.LyThuyet = Convert.ToInt32(tbLT.Text.Trim());
            mh.ThucHanh = Convert.ToInt32(tbTH.Text.Trim());
            //mh.ThucHanh = Convert.ToInt32(tbTH.Text.Trim());
            using (MonhocEntities db = new MonhocEntities())
            {
                db.Entry(mh).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

       


        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonhocEntities db = new MonhocEntities())
            {
                var entry = db.Entry(mh);
                if(entry.State == EntityState.Detached)    
                    db.Monhocs.Attach(mh);
                db.Monhocs.Remove(mh);
                db.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }
    }
}
