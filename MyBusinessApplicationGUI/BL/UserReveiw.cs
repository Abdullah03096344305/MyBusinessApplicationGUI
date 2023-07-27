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
        private int number;
        private int rating;
        private string message;
        public UserReveiw(string name, int number, int rating, string message)
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
        public int GetNumber()
        {
            return number;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        public int GetRating()
        {
            return rating;
        }
        public void SetRating(int rating)
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
