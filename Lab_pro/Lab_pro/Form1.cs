using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_pro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            login ob1 = new login();
            ob1.Show();   
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Signin obj = new Signin();
            obj.Show();
        }
    }
}
