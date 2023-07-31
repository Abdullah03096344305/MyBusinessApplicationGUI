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
    public partial class ViewDealForm : Form
    {
        public ViewDealForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DealListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewDealForm_Load(object sender, EventArgs e)
        {
            string burgerPath = "dealFile.txt";
            DealDL.ReadDealFile(burgerPath);
            UpdateListView();
        }
        private void AddDealToListView(Deals deal)
        {
            ListViewItem item = new ListViewItem(deal.GetName());
            item.SubItems.Add(deal.GetPrice().ToString());
            DealListView.Items.Add(item);
        }
        private void UpdateListView()
        {
            DealListView.Items.Clear(); // Clear existing items in the ListView.
            foreach (var deal in DealDL.GetDeals())
            {
                AddDealToListView(deal);
            }
        }


    }
}
