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
    public partial class DeleteDealMenu : Form
    {
        public DeleteDealMenu()
        {
            InitializeComponent();
        }
        string dealPath = "dealFile.txt";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DealListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Deal to remove.");
                return;
            }
            // Get the selected item.
            ListViewItem selectedItem = DealListView.SelectedItems[0];
            // Extract the burger name and price from the selected item.
            string dealName = selectedItem.SubItems[0].Text;
            int dealPrice = int.Parse(selectedItem.SubItems[1].Text);
            // Remove the selected item from the ListView.
            DealListView.Items.Remove(selectedItem);
            DealDL.RemoveDealFromList(dealName, dealPrice);           
            DealDL.UpdateDealFile(dealPath);
        }

        private void DeleteDealMenu_Load(object sender, EventArgs e)
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
        private void AddDealToListView(Deals deals)
        {
            ListViewItem item = new ListViewItem(deals.GetDealName());
            item.SubItems.Add(deals.GetDealPrice().ToString());
            DealListView.Items.Add(item);
        }
    }
}
