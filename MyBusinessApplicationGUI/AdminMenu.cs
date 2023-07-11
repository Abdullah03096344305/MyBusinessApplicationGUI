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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form UserM = new AdminChoiceForm();
            UserM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form UserM = new AdminChoiceForm();
            UserM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form UserM = new AdminChoiceForm();
            UserM.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form UserM = new AdminChoiceForm();
            UserM.Show();
        }
    }
}
