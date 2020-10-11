using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMonHoc
{
    public partial class New : Form
    {
        Monhoc mh = new Monhoc();


       
        public New()
        {
          

            InitializeComponent();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        private void Insert()
        {
            mh.IDMH = txtID.Text.Trim();
            mh.MA_HK = txtMMH.Text.Trim();
            mh.TenMH = txtTenMH.Text.Trim();
            mh.SoTC = Convert.ToInt32(txtTC.Text.Trim());
            mh.LyThuyet = Convert.ToInt32(txtLT.Text.Trim());
            mh.ThucHanh = Convert.ToInt32(txtTH.Text.Trim());

            using (MonhocEntities db = new MonhocEntities())
            {
                db.Monhocs.Add(mh);
                db.SaveChanges();
            }
            Form1 f = new Form1();
            MessageBox.Show("Added Successfully");
            this.Hide();
            f.loadData();
        }
   /*     public void delete()
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MonhocEntities db = new MonhocEntities())
                {
                    var entry = db.Entry(mh);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Monhocs.Attach(mh);
                    }
                    db.Monhocs.Remove(mh);
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }
   */

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
