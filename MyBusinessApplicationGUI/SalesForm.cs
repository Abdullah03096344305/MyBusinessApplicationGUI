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
    public partial class SalesForm : Form
    {
        private int totalPrice;
        public SalesForm()
        {
            InitializeComponent();
            totalPrice = Genral.TotalPrice;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
