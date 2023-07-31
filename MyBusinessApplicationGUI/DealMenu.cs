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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int GetDealPrice()
        {
            return dealtotalPrice;
        }


        private void DealMenu_Load(object sender, EventArgs e)
        {
            string dealPath = "dealFile.txt";
            DealDL.ReadDealFile(dealPath);
            UpdateListView();
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
        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxQuantity.Text = " ";
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
            ListViewItem item = new ListViewItem(deal.GetName());
            item.SubItems.Add(deal.GetPrice().ToString());
            DealListView.Items.Add(item);
        }
      
       
        
    }
}
