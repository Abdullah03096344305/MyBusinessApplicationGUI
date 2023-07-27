using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MyBusinessApplicationGUI.DL;
using MyBusinessApplicationGUI.BL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class DeleteBurgerMenu : Form
    {
        public DeleteBurgerMenu()
        {
            InitializeComponent();
        }
        string burgerPath = "burgerFile.txt";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBurgerMenu_Load(object sender, EventArgs e)
        {
            string burgerPath = "burgerFile.txt";
            BurgerDL.ReadBurgerFile(burgerPath);
            UpdateListView();
        }
        private void BurgerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        public void UpdateListView()
        {
            BurgerListView.Items.Clear(); // Clear existing items in the ListView.
            foreach (var burger in BurgerDL.GetBurgers())
            {
                AddBurgerToListView(burger); 
            }
        }
        private void AddBurgerToListView(Burger burger)
        {
            ListViewItem item = new ListViewItem(burger.GetBurgerName());
            item.SubItems.Add(burger.GetBurgerPrice().ToString());
            BurgerListView.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BurgerListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a burger to remove.");
                return;
            }

            // Get the selected item.
            ListViewItem selectedItem = BurgerListView.SelectedItems[0];

            // Extract the burger name and price from the selected item.
            string burgerName = selectedItem.SubItems[0].Text;
            int burgerPrice = int.Parse(selectedItem.SubItems[1].Text);

            // Remove the selected item from the ListView.
            BurgerListView.Items.Remove(selectedItem);

            // Remove the burger from the BurgerDL list.
            BurgerDL.RemoveBurgerFromList(burgerName, burgerPrice);

            // Update the burgerFile.txt with the updated burger list.            
            BurgerDL.UpdateBurgerFile(burgerPath);
        }
    }
}
