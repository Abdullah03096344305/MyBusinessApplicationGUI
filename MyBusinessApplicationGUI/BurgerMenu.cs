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
            BurgerDL.ReadBurgerFile(burgerPath);
            UpdateListView();
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
        public void UpdateListView()
        {
            BurgerListView.Items.Clear(); // Clear existing items in the ListView.
            foreach (var burger in BurgerDL.GetBurgers())
            {
                AddBurgerToListView(burger); // Add each burger from the BurgerDL list to the ListView.
            }
        }
        private void AddBurgerToListView(Burger burger)
        {
            ListViewItem item = new ListViewItem(burger.GetBurgerName());
            item.SubItems.Add(burger.GetBurgerPrice().ToString());
            BurgerListView.Items.Add(item);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
