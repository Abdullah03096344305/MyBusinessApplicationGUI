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
    public partial class BillMenu : Form
    {
        private int totalPrice;

        public BillMenu()
        {
            InitializeComponent();
            totalPrice = Genral.TotalPrice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillMenu_Load(object sender, EventArgs e)
        {                    
            textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void AdminKeyTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
