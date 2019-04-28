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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(215, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(215, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(215, 0, 0, 0);
            label1.Text=Cancel.temp;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sahil\\Documents\\Bus_reservation.accdb");
            OleDbDataAdapter da = new OleDbDataAdapter("select bus_name from busses", con);
            DataSet DS = new DataSet();
            da.Fill(DS);
            DataSet myData = DS;
            dataGridView1.DataSource = DS.Tables[0].DefaultView;
            dataGridView1.DataBindings.ToString();

            OleDbDataAdapter da2 = new OleDbDataAdapter("select  arriving_time from buses", con);
            DataSet DS2 = new DataSet();
            da.Fill(DS2);
            DataSet myData2 = DS2;
            dataGridView2.DataSource = DS2.Tables[0].DefaultView;
            dataGridView2.DataBindings.ToString();

            OleDbDataAdapter da3 = new OleDbDataAdapter("select  bus_number from buses", con);
            DataSet DS3 = new DataSet();
            da.Fill(DS3);
            DataSet myData3 = DS3;
            dataGridView3.DataSource = DS3.Tables[0].DefaultView;
            dataGridView3.DataBindings.ToString();




        }
    }
}
