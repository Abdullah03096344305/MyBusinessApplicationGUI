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
    public partial class UpdateDealForm : Form
    {
        public UpdateDealForm()
        {
            InitializeComponent();
        }

        private void UpdateDealForm_Load(object sender, EventArgs e)
        {
            string burgerPath = "dealFile.txt";
            DealDL.ReadDealFile(burgerPath);
            UpdateListView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSelectedDealPrice();
        }

        private void DealListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DealListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = DealListView.SelectedItems[0];
                string dealName = selectedItem.SubItems[0].Text;
                int currentPrice = int.Parse(selectedItem.SubItems[1].Text);
                textBox1.Text = currentPrice.ToString();
            }
            else
            {
                textBox1.Text = string.Empty;
            }
        }
        private void UpdateListView()
        {
            DealListView.Items.Clear(); // Clear existing items in the ListView.
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

        private void UpdateSelectedDealPrice()
        {
            if (DealListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = DealListView.SelectedItems[0];
                string dealName = selectedItem.SubItems[0].Text;
                Deals dealToUpdate = DealDL.deals.Find(deals => deals.GetDealName() == dealName);

                if (dealToUpdate != null)
                {
                    if (int.TryParse(textBox1.Text, out int newPrice))
                    {
                        dealToUpdate.SetDealPrice(newPrice);
                        DealListView.Items.Clear();
                        foreach (var updatedBurger in DealDL.GetDeals())
                        {
                            AddDealToListView(updatedBurger);
                        }
                        DealDL.UpdateDealFile("dealFile.txt");
                    }
                    else
                    {
                        MessageBox.Show("Invalid price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
