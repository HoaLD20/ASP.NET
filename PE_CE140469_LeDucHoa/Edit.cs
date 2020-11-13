using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_CE140469_LeDucHoa
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnCanle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        BILL bill = new BILL();
        private void btnDelete_Click(object sender, EventArgs e)
        {
           

                if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (PE_SE1401Entities db = new PE_SE1401Entities())
                    {
                        var entry = db.Entry(bill);
                        if (entry.State == EntityState.Detached)
                            db.BILLs.Attach(bill);
                        db.BILLs.Remove(bill);
                        db.SaveChanges();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bill.ID = Convert.ToInt32(tbIDDDDDDDDDD.Text.Trim());
            bill.Date = Convert.ToDateTime(tbDate.Text.Trim());
            bill.IDCustomer = tbIDCustomer.Text.Trim();
            bill.IDStaff = tbIDStaff.Text;
            bill.Total = (decimal?)Convert.ToDouble(tbTotal.Text.Trim());
           
            using (PE_SE1401Entities db = new PE_SE1401Entities())
            {
                db.Entry(bill).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
