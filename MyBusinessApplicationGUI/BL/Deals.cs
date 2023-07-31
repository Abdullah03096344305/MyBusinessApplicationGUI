using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.DL;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class Deals : Food
    {
        public Deals(string name, int price) : base(name, price)
        {
        }
    }
}
