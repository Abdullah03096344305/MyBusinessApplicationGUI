using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.BL
{
    class AdminKey
    {
        private string adminKey;       

        public AdminKey(string adminKey)
        {
            this.adminKey = adminKey;          
        }
        public string GetAdminKey()
        {
            return adminKey;
        }
        public void SetAdminKey(string adminKey)
        {
            this.adminKey = adminKey;
        }
    }
}
