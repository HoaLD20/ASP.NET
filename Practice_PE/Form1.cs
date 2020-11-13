using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_PE
{
    public partial class Form1 : Form
    {
        Customer cus = new Customer();
        List<Customer> customerList = new List<Customer>();
        BindingList<Customer> customerBind;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();

        }
        public void loadData()
        {
            using (PE_PracticeEntities db = new PE_PracticeEntities())
            {
                customerList = db.Customers.ToList<Customer>();
                customerBind = new BindingList<Customer>(customerList);
                tableData.DataSource = customerBind;

            }
            //tableData.AutoGenerateColumns = false;

        }
    }
}
