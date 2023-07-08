using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class MUser
    {
        private string userName;
        private string userPassword;

        public MUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
        public string GetUserName()
        {
            return userName;
        }
        public string GetUserPassword()
        {
            return userPassword;
        }
    }
}
