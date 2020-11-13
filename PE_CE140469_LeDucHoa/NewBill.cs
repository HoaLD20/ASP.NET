using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_CE140469_LeDucHoa
{
    public partial class NewBill : Form
    {
        public NewBill()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        BILL bill = new BILL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            bill.ID = Convert.ToInt32(tbIDDDDDDDDDD.Text.Trim());
            bill.Date = Convert.ToDateTime(tbDate.Text.Trim());
            bill.IDCustomer = tbIDCustomer.Text.Trim();
            bill.IDStaff = tbIDStaff.Text.Trim();
            bill.Total = (decimal?)Convert.ToDouble(tbTotal.Text.Trim());

            using (PE_SE1401Entities db = new PE_SE1401Entities())
            {
                db.BILLs.Add(bill);
                db.SaveChanges();
            }
            Form1 f = new Form1();
            MessageBox.Show("Added Successfully");
            this.Hide();
            f.loadData();
        }

        private void txtTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
