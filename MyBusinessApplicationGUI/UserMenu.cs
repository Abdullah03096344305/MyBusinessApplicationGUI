using MyBusinessApplicationGUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class UserMenu : Form
    {
        bool sidebarExpand ;
        public UserMenu()
        {
            InitializeComponent();
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();           
        }
        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form UserM = new UserMenu();
            UserM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form UserM = new UserSideReviewForm();
            UserM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form UserM = new DeliveryMenu();
            UserM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form UserM = new Smashers();
            UserM.Show();
        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 65)
                {
                    sidebarExpand = false;                   
                    sidebarTimer.Stop();
                }                
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 250)
                {
                    sidebarExpand = true;                  
                    sidebarTimer.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form UserM = new BurgerMenu();
            UserM.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form UserM = new DealMenu();
            UserM.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form UserM = new BillMenu();
            UserM.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form UserM = new DeliveryMenu();
            UserM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form UserM = new StoryMenu();
            UserM.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form UserM = new LocationMenu();
            UserM.Show();
        }
    }
}
