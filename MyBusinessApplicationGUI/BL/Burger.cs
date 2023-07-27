using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.DL;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class Burger
    {
        private string burgerName;
        private int burgerPrice;
        public Burger(string burgerName, int burgerPrice)
        {
            this.burgerName = burgerName;
            this.burgerPrice = burgerPrice;
        }
        public string GetBurgerName()
        {
            return burgerName;
        }
        public int GetBurgerPrice()
        {
            return burgerPrice;
        }
        public void SetBurgerName(string burgerName)
        {
            this.burgerName = burgerName;
        }
        public void SetBurgerPrice(int burgerPrice)
        {
            this.burgerPrice = burgerPrice;
        }
    }
}
