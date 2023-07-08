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
    public partial class SignInUpForm : Form
    {
        public SignInUpForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form SignUP = new SignUpForm();
            SignUP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form SignIN = new SignInForm();
            SignIN.Show();
        }
    }
}
