using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MyBusinessApplicationGUI.DL;
using MyBusinessApplicationGUI.BL;
using System.Windows.Forms;


namespace MyBusinessApplicationGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string burgerPath = "burgerFile.txt";
        private void AddBurgerIntoListView(Burger burger, ListView listView)
        {
            ListViewItem item = new ListViewItem(burger.GetBurgerName());
            item.SubItems.Add(burger.GetBurgerPrice().ToString());
            listView.Items.Add(item);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string burgerName = textBox1.Text;
            string burgerPrice = textBox2.Text;
            int price = int.Parse(burgerPrice);
            Burger burger = new Burger(burgerName, price);
            BurgerDL.AddBurgerToList(burger);         
            BurgerDL.StoreUserIntoFile(burger, burgerPath); 
            CLearDataFromForm();
        }
        private void CLearDataFromForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BurgerDL.ReadBurgerFile(burgerPath);
        }
        
    }
}
