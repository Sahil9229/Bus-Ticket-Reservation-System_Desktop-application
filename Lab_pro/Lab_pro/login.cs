using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab_pro
{
    public partial class login : Form
    {
        public static string Flag = "";
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

      //  private void textBox1_Click(object sender, EventArgs e)
     //   {
           
       // }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.White;
            textBox2.PasswordChar = '*';
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.ForeColor = Color.White;
            textBox4.PasswordChar = '*';
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.White;
        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "user name required";
            }

            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Red;
                textBox2.Text = "password required";
            }

        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = "user name required";
            }

            if (textBox4.Text == "")
            {
                textBox4.ForeColor = Color.Red;
                textBox2.Text = "password required";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Signin obj = new Signin();
            obj.Show();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
           textBox1.Text = "";
            textBox1.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "User Name")
                MessageBox.Show("User name cannot be empty");
            else if (textBox2.Text == "" || textBox2.Text == "Password")
                MessageBox.Show("Password cannot be empty");
            else
             {

                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sahil\\Documents\\Bus_reservation.accdb");

                string cmdText = "select count(*) from login where user_name = " + " ? and[password] =? ";
                OleDbCommand cmd = new OleDbCommand(cmdText, connection);
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                     {
                        Admin obj = new Admin();
                        obj.Show();
                        this.Close();

                    }
                    else
                        MessageBox.Show("Login Fail");
                }
                connection.Close();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox3.Text == "User Name")
                MessageBox.Show("User name cannot be empty");
            else if (textBox4.Text == "" || textBox4.Text == "Password")
                MessageBox.Show("Password cannot be empty");
            else
            {

                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sahil\\Documents\\Bus_reservation.accdb");

                string cmdText = "select count(*) from client where user_name = " + " ? and[password] =? ";
                OleDbCommand cmd = new OleDbCommand(cmdText, connection);
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@p1", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox4.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        Admin obj = new Admin();
                        obj.Show();
                        this.Close();

                    }
                    else
                        MessageBox.Show("Login Fail");
                }
                connection.Close();

            }



        }
    }
}
