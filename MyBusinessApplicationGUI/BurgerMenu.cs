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
    public partial class BurgerMenu : Form
    {
        public int totalPrice;
        public BurgerMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int GetBurgerPrice()
        {
            return totalPrice;
        }
        private void BurgerMenu_Load(object sender, EventArgs e)
        {
            string burgerPath = "burgerFile.txt";
            BurgerDL.ReadBurgerFile(burgerPath, BurgerListView);
        }

        private void BurgerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BurgerListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in BurgerListView.SelectedItems)
                {
                    int price;
                    int quantity;
                    if (int.TryParse(selectedItem.SubItems[1].Text, out price) && int.TryParse(textBoxQuantity.Text, out quantity))
                    {
                        int itemTotal = price * quantity;
                        totalPrice += itemTotal;
                       
                        /* int v = genral.GetPrice();
                         MessageBox.Show(v.ToString());*/

                    }
                }              
                textBoxTotalPrice.Text = GetBurgerPrice().ToString();
                Genral.TotalPrice = totalPrice;

            }

        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxQuantity.Text = " ";
        }
    }
}
