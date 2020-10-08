using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CRUDMonHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
           
            InitializeComponent();
           
        }


        private void loadData(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test_db.users", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dataGridView1.DataSource = ds.Tables["users"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    


    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
