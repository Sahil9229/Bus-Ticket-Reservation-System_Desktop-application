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
    public partial class Cancel : Form
    {


        public static string temp = "";

        public Cancel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sahil\\Documents\\Bus_reservation.accdb");
            string  tempTitle = textBox1.Text;
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Book WHERE Title = tempTitle", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            temp = richTextBox1.Text;
            Main obj = new Main();
            obj.Show();
            this.Close();

        }
    }
}
