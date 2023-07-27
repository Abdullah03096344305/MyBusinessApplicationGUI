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
    public partial class AddBurgerMenu : Form
    {
        public AddBurgerMenu()
        {
            InitializeComponent();
        }
        string burgerPath = "burgerFile.txt";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBurgerMenu_Load(object sender, EventArgs e)
        {
            BurgerDL.ReadBurgerFile(burgerPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string burgerName = textBox1.Text;
            string burgerPrice = textBox2.Text;
            int price = int.Parse(burgerPrice);
            Burger burgers = new Burger(burgerName, price);
            BurgerDL.AddBurgerToList(burgers);
            BurgerDL.StoreUserIntoFile(burgers, burgerPath);
            CLearDataFromForm();
        }
        private void CLearDataFromForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
