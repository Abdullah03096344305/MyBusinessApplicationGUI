using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class UserCheckAdminorCustomer : Form
    {
        public UserCheckAdminorCustomer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yahan pr admin menu show krwain gy 
             Form admincheck = new AdminCheck();
             admincheck.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //yahan pr user menu show krwain gy 
            // Form UserM = new UserMenu();
            //   UserM.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
