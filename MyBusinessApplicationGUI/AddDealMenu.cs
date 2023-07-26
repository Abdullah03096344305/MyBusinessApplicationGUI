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
    public partial class AddDealMenu : Form
    {
        public AddDealMenu()
        {
            InitializeComponent();
        }
        string dealPath = "dealFile.txt";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDealMenu_Load(object sender, EventArgs e)
        {
            DealDL.ReadDealFile(dealPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dealName = textBox1.Text;
            string dealPrice = textBox2.Text;
            int price = int.Parse(dealPrice);
            Deals deals = new Deals(dealName, price);
            DealDL.AddDealToList(deals);
            DealDL.StoreUserIntoFile(deals, dealPath);
            CLearDataFromForm();
        }
        private void CLearDataFromForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
