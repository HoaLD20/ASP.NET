using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMonHoc
{
    public partial class Edit : Form
    {
        public Edit()
        {
            /*
            Monhoc mh = new Monhoc();

            using (MonhocEntities db = new MonhocEntities())
            {
                mh = db.Monhocs.Where(x => x.IDMH == mh.IDMH).FirstOrDefault();

                tbID.Text = mh.IDMH;
                tbMMH.Text = mh.MA_HK;
                tbMH.Text = mh.TenMH;
                tbTC.Text = Convert.ToString(mh.SoTC);
                tbTH.Text = Convert.ToString(value: mh.ThucHanh);
                tbLT.Text = Convert.ToString(value: mh.LyThuyet);
            }
            */
            InitializeComponent();
        }
        
           

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {

          
        }
    }
}
