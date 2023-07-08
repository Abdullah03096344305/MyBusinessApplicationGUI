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
    public partial class AdminCheck : Form
    {
        public AdminCheck()
        {
            InitializeComponent();
            string adminKeyPath = "AdminKeyData.txt";
            AdminKeyDL.ReadDataFromFile(adminKeyPath);
            
        }
        private void CLearDataFromForm()
        {
            AdminKeyTextbox.Text = "";
           
        }
        private void AdminCheck_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminKeyTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            string adminkey = AdminKeyTextbox.Text;           
            AdminKey keys = new AdminKey(adminkey);
            AdminKey validUser = AdminKeyDL.SignIn(keys);
            if (validUser != null)
            {
                /* Form moreForm = new AdminMenu();
                 moreForm.Show();*/
                MessageBox.Show("Hola");
            }
            else
            {
                MessageBox.Show("User is Invalid ");
            }
            CLearDataFromForm();
        }
    }
}
