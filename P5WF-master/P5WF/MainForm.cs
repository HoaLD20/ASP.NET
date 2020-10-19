using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            new BDTForm().Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            new NDTForm().Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            new SVForm().Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
