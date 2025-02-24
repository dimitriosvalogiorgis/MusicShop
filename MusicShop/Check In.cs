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
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace MusicShop
{
    public partial class CheckIn : Form
    {
        Customers thirdForm = new Customers();
        FormMusicCollection fourthForm = new FormMusicCollection();
        SpecialOrders fifthForm = new SpecialOrders();
        private string server = "localhost";
        private string database = "music";
        private string UserName = "root";
        private string Password = "";
        string connectionString2;
        MySqlConnection Connection2;

        public CheckIn()
        {
            InitializeComponent();
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            thirdForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            fourthForm.Show();
        }
        private void buttonSO_Click(object sender, EventArgs e)
        {
            this.Close();
            fifthForm.Show();
        }



        private void ShowStaff_Click(object sender, EventArgs e)
        {
           
            string TABLE = "staff";

            
            connectionString2 = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;
            Connection2 = new MySqlConnection(connectionString2);

            
            if (Connection2.State != ConnectionState.Open)
            {
                Connection2.Open();
            }

            try
            {
                MySqlCommand cmd2 = Connection2.CreateCommand();
                cmd2.CommandText = "SELECT * FROM " +
                    "" + TABLE;
                MySqlDataAdapter adap2 = new MySqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                adap2.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (Connection2.State == ConnectionState.Open)
                {
                    Connection2.Close();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

       
       private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
