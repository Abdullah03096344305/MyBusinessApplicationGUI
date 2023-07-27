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
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KeyForm_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            string password = Password.Text;
            string path = "AdminKeyData.txt";
            AdminKey key = new AdminKey(password);
            AdminKeyDL.AddUserIntoList(key);
            AdminKeyDL.StoreUserIntoFile(key, path);
            MessageBox.Show("New Key Added SuccessFully");
            CLearDataFromForm();
        }
        private void CLearDataFromForm()
        {
            Password.Text = "";
        }
    }
}
