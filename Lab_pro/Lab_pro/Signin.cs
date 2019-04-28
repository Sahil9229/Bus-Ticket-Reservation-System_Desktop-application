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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\sahil\\Documents\\Bus_reservation.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into client values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")", con);
            Console.WriteLine("{0} {1} {2}",textBox1.Text,textBox2.Text,textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
