using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.DL;
using MyBusinessApplicationGUI.BL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string path = "data.txt";
            MUser user = new MUser(username, password);
            MUserDL.AddUserIntoList(user);
            MUserDL.StoreUserIntoFile(user, path);
            MessageBox.Show("User Added SuccessFully");
            CLearDataFromForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
