using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            mh.IDMH = txtMMH.Text.Trim();
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
            
            MessageBox.Show("Submitted Successfully");
            this.Hide();
            f.loadData();
        }
        private void New_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();  
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = txtLT.Text = txtMMH.Text = txtTC.Text = txtTH.Text = "";
        }

        
    }
}
