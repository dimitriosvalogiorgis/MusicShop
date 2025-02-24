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

namespace MusicShop
{
    public partial class Login : Form
    {
        CheckIn secondForm = new CheckIn();

        private string server = "localhost";
        private string database = "music";
        private string UserName = "root";
        private string Password = "";

        string connectionString;
        MySqlConnection Connection;

        public Login()
        {
            InitializeComponent();

            MakeInitialConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            label4.Parent = pictureBox2;
            label4.BackColor = Color.Transparent;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string USERNAME;
            string PASSWORD;
            int LoginFlag = 0;

            //OPEN CONNECTION IF CLOSED.
            if (Connection.State != ConnectionState.Open)
            {
                //SETUP DB
                connectionString = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;

                //MAKE CONNECTION
                Connection = new MySqlConnection(connectionString);
                
                //OPEN CONNECTION
                Connection.Open();
              
                //Connection.Close();
            }
            else
            {
                MessageBox.Show("CLOSED!");
            }

            try
            {
                MySqlCommand cmd = Connection.CreateCommand();

                //SQL QUERY
                cmd.CommandText = "SELECT * FROM LoginTable;";
                MySqlDataReader reader = cmd.ExecuteReader();

                //READS IN THE ENTIRE DB
                while (reader.Read())
                {
                    //VAR
                    USERNAME = reader.GetString("LogUserName");
                    PASSWORD = reader.GetString("LogPassword");

                    //FLAG USED BECAUSE OF WHILE, OR ELSE MESSAGE SHOWS FOR ALL ROWS
                    if ((textBoxUsername.Text == USERNAME) & (textBoxPassword.Text == PASSWORD))
                        LoginFlag = 1;
                }

                if (LoginFlag == 1)
                {
                    MessageBox.Show("Welcome!");                    
                    this.Hide();
                    secondForm.Show();
                }
                else
                {
                    MessageBox.Show("You may have entered incorrect Username/Password");
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
        private void MakeInitialConnection()
        {
            connectionString = @"Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + UserName + ";" + "Password=" + Password;
            Connection = new MySqlConnection(connectionString);
            Connection.Open();

            if (Connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection OK!");
                Connection.Close();
            }
            else
            {
                MessageBox.Show("Connection invalid.");
            }
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
