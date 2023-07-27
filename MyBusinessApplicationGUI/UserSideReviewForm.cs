using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.BL;
using MyBusinessApplicationGUI.DL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class UserSideReviewForm : Form
    {
        public UserSideReviewForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string userNumber = textBox2.Text;
            string userRating = textBox3.Text;
            string userMessage = textBox4.Text;
            int Number = int.Parse(userNumber);
            int Rating = int.Parse(userRating);
            string ReveiwFilePath = "ReveiwFile.txt";
            UserReveiw user = new UserReveiw(userName, Number,Rating,userMessage);
            UserReveiwDL.AddReveiwIntoList(user);
            UserReveiwDL.StoreUserIntoFile(user, ReveiwFilePath);
            MessageBox.Show("Review Added SuccessFully");
            ClearDataFromFrom();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearDataFromFrom()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
