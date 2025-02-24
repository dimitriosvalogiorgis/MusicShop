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
    public partial class SpecialOrders : Form
    {
        
        private string server = "localhost";
        private string database = "music";
        private string UserName = "root";
        private string Password = "";
        string connectionString;
        string connectionString2;
        MySqlConnection Connection;
        MySqlConnection Connection2;


        private void button2_Click(object sender, EventArgs e)
        {
            CheckIn secondForm = new CheckIn();
            this.Close();
            secondForm.Show();
        }
        private void SpecialOrders_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
        }

        public SpecialOrders()
        {
            InitializeComponent();
            textBoxid.Enabled = false;
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxMusicID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SOS - Connects to DB and opens objects so we can read them.
            //MakeInitialConnection();
            string TABLE = "specialcust";

            //SOS - have to make connection objects first before reading them.
            connectionString2 = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;
            Connection2 = new MySqlConnection(connectionString2);

            //Open connection IF CLOSED.
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

        private void button3_Click(object sender, EventArgs e)
        {
                try
                {
                    //Set up the server name and login details.
                    connectionString = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;

                    //Set the query to write
                    //Dont need to ADD ID, its automatically added.
                    string Query = "insert into music.specialcust(Firstname,Lastname,Email,Mobile,MuCoID) values('" + this.textBoxFirstName.Text + "','" + this.textBoxLastName.Text + "','" + this.textBoxEmail.Text + "','" + this.textBoxMobile.Text + "','" + this.textBoxMusicID.Text + "');";

                    //Set up connection to write to DB
                    MySqlConnection MyConnection2 = new MySqlConnection(connectionString);

                    //Sort out the connection object
                    MySqlCommand MyCommandConnection = new MySqlCommand(Query, MyConnection2);

                    //Sort out the reader to write to the DB
                    MySqlDataReader MyReader2;

                    //Open the reader connection.
                    MyConnection2.Open();

                    //Execute reader.
                    MyReader2 = MyCommandConnection.ExecuteReader();

                    MessageBox.Show("New record successfully written!");

                    //Read in data.
                    while (MyReader2.Read())
                    {
                    }
                    MyConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Let user choose the ID (ROW) to delete.
            string Choice = Interaction.InputBox("Choose the ID to delete?", "DELETE");
            //Convert the string to an int.
            int IDToDelete = Int32.Parse(Choice);

            try
            {
                //Establish db connection
                connectionString = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;
                string Query = "delete from music.specialcust where id=" + IDToDelete;
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                //Open connection
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MessageBox.Show("Record deleted, database updated!");
                MyConn2.Close();
                //FUNCTIONSHOWALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //THIS ALL NEEDS CHANGING SO THAT WE CAN CLICK ON THE ROW TO UPDATE THEN DISPLAY THE DATA INSIDE THE TEXTBOXES, THEN CHANGE WHAT YOU WANT.

            if (textBoxid.Text == "")
            {
                //FUNCTIONSHOWALL();
                MessageBox.Show("Please click on an element in the database!");
            }
            else
            {
                //Let user choose the ID (ROW) to update.
                //string Choice = Interaction.InputBox("Choose the ID to update?", "UPDATE");
                //int IDToUpdate = Int32.Parse(Choice);

                try
                {
                    connectionString = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;
                    //This needs changing to be able to update whatever you type in (name, age etc).
                    string Query = "UPDATE music.specialcust SET Firstname = '" + this.textBoxFirstName.Text + "',  Lastname = '" + this.textBoxLastName.Text + "',  Email = '" + this.textBoxEmail.Text + "',  Mobile = '" + this.textBoxMobile.Text + "',  MuCoID = '" + this.textBoxMusicID.Text + "' WHERE iD = '" + this.textBoxid.Text + "'; ";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated successfully.");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here  
                    //FUNCTIONSHOWALL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            textBoxid.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxMobile.Text = "";
            textBoxMusicID.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
