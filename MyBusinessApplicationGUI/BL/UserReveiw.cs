using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class UserReveiw
    {
        private string name;
        private double number;
        private double rating;
        private string message;
        public UserReveiw(string name, double number, double rating, string message)
        {
            this.name = name;
            this.number = number;
            this.rating = rating;
            this.message = message;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetNumber()
        {
            return number;
        }
        public void SetNumber(double number)
        {
            this.number = number;
        }
        public double GetRating()
        {
            return rating;
        }
        public void SetRating(double rating)
        {
            this.rating = rating;
        }
        public string GetMessage()
        {
            return message;
        }
        public void SetMessage(string message)
        {
            this.message = message;
        }
    }
}
