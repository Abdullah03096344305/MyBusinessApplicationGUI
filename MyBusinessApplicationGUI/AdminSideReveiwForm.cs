using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MyBusinessApplicationGUI.BL;
using MyBusinessApplicationGUI.DL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class AdminSideReveiwForm : Form
    {
        public AdminSideReveiwForm()
        {
            InitializeComponent();
        }

        private void UserListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminSideReveiwForm_Load(object sender, EventArgs e)
        {
            string reveiwPath = "ReveiwFile.txt";
            UserReveiwDL.ReadDataFromFile(reveiwPath);
            UpdateListView();
        }
        private void UpdateListView()
        {
            UserListView.Items.Clear(); // Clear existing items in the ListView.
            foreach (var user in UserReveiwDL.GetUsers())
            {
                AddUserToListView(user);
            }
        }
        private void AddUserToListView(UserReveiw user)
        {
            ListViewItem item = new ListViewItem(user.GetName());
            item.SubItems.Add(user.GetNumber().ToString());
            item.SubItems.Add(user.GetRating().ToString());
            item.SubItems.Add(user.GetMessage());
            UserListView.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
