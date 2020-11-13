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
    public partial class UpdateToTal : Form
    {
        public UpdateToTal()
        {
            InitializeComponent();
        }
        BILL bill = new BILL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            double oldTotal = Convert.ToDouble(tbTotal.Text.Trim());

            if ((oldTotal +1) > Convert.ToDouble(tbTotal.Text.Trim()))
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
                MessageBox.Show("Total updated!");
               
            }
            else
            {
                MessageBox.Show("Total update fail - Value must be greater than old value!");

            }
           
        }
    }
}
