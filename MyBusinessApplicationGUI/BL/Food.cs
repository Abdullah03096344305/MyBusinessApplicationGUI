using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.DL;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class Food
    {
        protected string name;
        private int price;

        public Food(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public int GetPrice()
        {
            return price;
        }

    }
}
