using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBusinessApplicationGUI.DL;
using MyBusinessApplicationGUI.BL;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        private void CLearDataFromForm()
        {
            UserName.Text = "";
            Password.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            MUser user = new MUser(username, password);
            MUser validUser = MUserDL.SignIn(user);
            if (validUser != null)
            {
                /* Form moreForm = new AdminCheck();
                 moreForm.Show();*/
                MessageBox.Show("Hello World");

            }
            else
            {
                MessageBox.Show("User is Invalid ");
            }
            CLearDataFromForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
