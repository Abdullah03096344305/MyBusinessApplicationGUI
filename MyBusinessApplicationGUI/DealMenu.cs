using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBusinessApplicationGUI.BL;
using MyBusinessApplicationGUI.DL;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class DealMenu : Form
    {
        private int dealtotalPrice = 0;
        public DealMenu()
        {
            InitializeComponent();
        }
       /* int totalPrice;*/
        private void DealMenu_Load(object sender, EventArgs e)
        {
            string dealPath = "dealFile.txt";
            DealDL.ReadDealFile(dealPath);
            UpdateListView();
        }
        public void UpdateListView()
        {
            DealListView.Items.Clear(); 
            foreach (var deal in DealDL.GetDeals())
            {
                AddDealToListView(deal);
            }
        }
        private void AddDealToListView(Deals deal)
        {
            ListViewItem item = new ListViewItem(deal.GetDealName());
            item.SubItems.Add(deal.GetDealPrice().ToString());
            DealListView.Items.Add(item);
        }
        public int GetDealPrice()
        {
            return dealtotalPrice;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxQuantity.Text = " ";
        }
        private void DealListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DealListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in DealListView.SelectedItems)
                {
                    int price;
                    int quantity;
                    if (int.TryParse(selectedItem.SubItems[1].Text, out price) && int.TryParse(textBoxQuantity.Text, out quantity))
                    {
                        int itemTotal = price * quantity;
                        dealtotalPrice += itemTotal;
                    }
                }
                textBoxTotalPrice.Text = GetDealPrice().ToString();
                Genral.TotalPrice += dealtotalPrice;
            }
        }
    }
}
