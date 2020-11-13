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
    public partial class Form1 : Form
    {
        //Create list and binding list for storing data
        List<BILL> listBill = new List<BILL>();
        BILL bill = new BILL();
        BindingList<BILL> blistBill = new BindingList<BILL>();

        public Form1()
        {
            InitializeComponent();
            loadData();
        }
        Edit edit = new Edit();
        UpdateToTal update = new UpdateToTal();
        //public double huhu = Convert.ToDouble(tableData.CurrentRow.Cells[4].Value.ToString());
        private void tableData_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableData.CurrentRow.Index != -1)
            {
                bill.ID = (int)tableData.CurrentRow.Cells["ID"].Value;
                using (PE_SE1401Entities db = new PE_SE1401Entities())
                {
                    bill = db.BILLs.Where(x => x.ID == bill.ID).FirstOrDefault();
                    update.tbIDDDDDDDDDD.Text = bill.ID.ToString();
                    update.tbDate.Text = this.tableData.CurrentRow.Cells[1].Value.ToString();
                    update.tbIDCustomer.Text = this.tableData.CurrentRow.Cells[2].Value.ToString();
                    update.tbIDStaff.Text = this.tableData.CurrentRow.Cells[3].Value.ToString();
                    update.tbTotal.Text = this.tableData.CurrentRow.Cells[4].Value.ToString();
                    //string lt = this.tableData.CurrentRow.Cells[5].Value.ToString();
                    //edit.tbLT.Text = lt;

                    update.ShowDialog();
                }


            }
            
        }
        public void loadData()
        {
            using (PE_SE1401Entities billDB = new PE_SE1401Entities())
            {
                listBill = billDB.BILLs.ToList<BILL>();
                blistBill = new BindingList<BILL>(listBill);
                tableData.DataSource = listBill;

            }
            //tableData.AutoGenerateColumns = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
            new NewBill().ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new UpdateToTal().ShowDialog();
        }

        private void tableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
