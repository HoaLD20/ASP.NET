﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace CRUDMonHoc
{
    public partial class Form1 : Form
    {


        

        Monhoc mh = new Monhoc();
        List<Monhoc> list = new List<Monhoc>();
        BindingList<Monhoc> hihi;


        public Form1()
        {

            InitializeComponent();
            //Console.WriteLine(getValue().IDMH);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            using (MonhocEntities db = new MonhocEntities())
            {
                list = db.Monhocs.ToList<Monhoc>();
                hihi = new BindingList<Monhoc>(list);
                tableData.DataSource = hihi;

            }
            //tableData.AutoGenerateColumns = false;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new New().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Edit().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
        Edit edit = new Edit();

        private void tableData_DoubleClick(object sender, EventArgs e)
        {

            if (tableData.CurrentRow.Index != -1)
            {
                mh.IDMH = Convert.ToString(tableData.CurrentRow.Cells["IDMH"].Value);
                using (MonhocEntities db = new MonhocEntities())
                {
                    mh = db.Monhocs.Where(x => x.IDMH == mh.IDMH).FirstOrDefault();
                    edit.tbIDDDDDDDDDD.Text = mh.IDMH.ToString();
                    edit.tbMMH.Text = this.tableData.CurrentRow.Cells[1].Value.ToString();
                    edit.tbMH.Text = this.tableData.CurrentRow.Cells[2].Value.ToString();
                    edit.tbTC.Text = this.tableData.CurrentRow.Cells[3].Value.ToString();
                    edit.tbTH.Text = this.tableData.CurrentRow.Cells[4].Value.ToString();
                    edit.tbLT.Text = this.tableData.CurrentRow.Cells[5].Value.ToString();
                    //string lt = this.tableData.CurrentRow.Cells[5].Value.ToString();
                    //edit.tbLT.Text = lt;

                    edit.ShowDialog();
                }


            }

            

        }

       /*
        public Monhoc getValue()
        {
            Monhoc mh2 = new Monhoc();
            foreach (DataGridViewCell cell in tableData.SelectedRows[1].Cells)
            {
                if (cell.Value != null)
                {
                    mh2.IDMH = this.tableData.CurrentRow.Cells[0].Value.ToString();
                    mh2.MA_HK = this.tableData.CurrentRow.Cells[1].Value.ToString();
                    mh2.TenMH = this.tableData.CurrentRow.Cells[2].Value.ToString();
                    mh2.SoTC = Convert.ToInt32(this.tableData.CurrentRow.Cells[3].Value.ToString());
                    mh2.ThucHanh = Convert.ToInt32(this.tableData.CurrentRow.Cells[4].Value.ToString());
                    mh2.LyThuyet = Convert.ToInt32(this.tableData.CurrentRow.Cells[5].Value.ToString());
                }
            }
            return mh2;
        }
       */
        //**********************************//

        

        //*********************************//




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)

        { 

           
        }


        private void deleteHelp(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
