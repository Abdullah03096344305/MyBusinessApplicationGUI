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
    public partial class ViewBurgerForm : Form
    {
        public ViewBurgerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewBurgerForm_Load(object sender, EventArgs e)
        {
            string burgerPath = "burgerFile.txt";
            BurgerDL.ReadBurgerFile(burgerPath);
            UpdateListView();
        }

        private void BurgerListView_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            ListViewItem item = new ListViewItem(burger.GetName());
            item.SubItems.Add(burger.GetPrice().ToString());
            BurgerListView.Items.Add(item);
        }
    }
}
