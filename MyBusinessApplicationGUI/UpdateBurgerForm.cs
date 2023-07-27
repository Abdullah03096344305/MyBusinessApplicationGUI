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
    public partial class UpdateBurgerForm : Form
    {
        public UpdateBurgerForm()
        {
            InitializeComponent();
        }       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BurgerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BurgerListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BurgerListView.SelectedItems[0];
                string burgerName = selectedItem.SubItems[0].Text;
                int currentBurgerPrice = int.Parse(selectedItem.SubItems[1].Text);
                textBox1.Text = currentBurgerPrice.ToString();
            }
            else
            {
                textBox1.Text = string.Empty;
            }
        }

        private void UpdateBurgerForm_Load(object sender, EventArgs e)
        {
            string burgerPath = "burgerFile.txt";
            BurgerDL.ReadBurgerFile(burgerPath);
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSelectedBurgerPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateListView()
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

        private void UpdateSelectedBurgerPrice()
        {
            if (BurgerListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BurgerListView.SelectedItems[0];
                string burgerName = selectedItem.SubItems[0].Text;
                Burger burgerToUpdate = BurgerDL.burgers.Find(burger => burger.GetBurgerName() == burgerName);

                if (burgerToUpdate != null)
                {
                    if (int.TryParse(textBox1.Text, out int newPrice))
                    {
                        burgerToUpdate.SetBurgerPrice(newPrice);
                        BurgerListView.Items.Clear();
                        foreach (var updatedBurger in BurgerDL.GetBurgers())
                        {
                            AddBurgerToListView(updatedBurger);
                        }
                        BurgerDL.UpdateBurgerFile("burgerFile.txt");
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
