using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            form1.CenterToScreen();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD c = new CRUD();
            c.Show();

        }
    }
}
