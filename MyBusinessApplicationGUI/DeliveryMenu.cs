using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.BL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class DeliveryMenu : Form
    {
        private int totalPrice;
        public DeliveryMenu()
        {
            InitializeComponent();
            totalPrice = Genral.TotalPrice;
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
        int deliverycharges;
        private void DeliveryMenu_Load(object sender, EventArgs e)
        {
            textBoxTotalPrice.Text = totalPrice.ToString();
            if(totalPrice >= 500 && totalPrice < 1000)
            {
                deliverycharges = 150;
            }
            if (totalPrice < 500 && totalPrice > 0)
            {
                deliverycharges = 180;
            }
            if (totalPrice > 1000 && totalPrice == 0)
            {
                deliverycharges = 0;
            }
            textBoxDeliveryCharges.Text = deliverycharges.ToString();
        }
    }
}
