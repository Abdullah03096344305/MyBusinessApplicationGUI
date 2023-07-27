using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.DL;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class Deals
    {
        private string dealName;
        private int dealPrice;
        public Deals(string dealName, int dealPrice)
        {
            this.dealName = dealName;
            this.dealPrice = dealPrice;
        }
        public string GetDealName()
        {
            return dealName;
        }
        public int GetDealPrice()
        {
            return dealPrice;
        }
        public void SetDealName(string dealName)
        {
            this.dealName = dealName;
        }
        public void SetDealPrice(int dealPrice)
        {
            this.dealPrice = dealPrice;
        }
    }
}
