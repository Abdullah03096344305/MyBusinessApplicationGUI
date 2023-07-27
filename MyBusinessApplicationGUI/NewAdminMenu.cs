using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI
{
    public partial class NewAdminMenu : Form
    {
        public NewAdminMenu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPlaylistSubMenu);
        }
        private void CustomizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelEqulizerSubMenu.Visible = false;   
            panelToolsSubMenu.Visible = false;
            panelHelpSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if(panelMediaSubMenu.Visible == true)
            {
                panelMediaSubMenu.Visible = false;
            }
            if (panelPlaylistSubMenu.Visible == true)
            {
                panelPlaylistSubMenu.Visible = false;
            }
            if (panelEqulizerSubMenu.Visible == true)
            {
                panelEqulizerSubMenu.Visible = false;
            }
            if (panelToolsSubMenu.Visible == true)
            {
                panelToolsSubMenu.Visible = false;
            }
            if (panelHelpSubMenu.Visible == true)
            {
                panelHelpSubMenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMediaSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForms(new AddBurgerMenu());
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForms(new AddDealMenu());
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForms(new DeleteBurgerMenu());
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForms(new DeleteDealMenu());
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForms(new UpdateBurgerForm());
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForms(new UpdateDealForm());
            HideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForms(new ViewBurgerForm());
            HideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForms(new ViewDealForm());
            HideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // your code here
            //....
            HideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // your code here
            //....
            HideSubMenu();
        }

        private void btnEquilizer_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEqulizerSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolsSubMenu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHelpSubMenu);
        }
        private Form ActiveForm = null;
        private void OpenChildForms(Form ChildForm)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close(); 
            }
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;   
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ActiveForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForms(new KeyForm());
            HideSubMenu();
        }
    }
}
