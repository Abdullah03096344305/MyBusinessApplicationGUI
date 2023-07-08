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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
