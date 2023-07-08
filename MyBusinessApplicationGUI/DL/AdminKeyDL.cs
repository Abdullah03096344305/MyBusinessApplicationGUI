using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.BL;
using System.Threading.Tasks;
using System.IO;

namespace MyBusinessApplicationGUI.DL
{
    class AdminKeyDL
    {
        private static List<AdminKey> userList = new List<AdminKey>();
        public static void AddUserIntoList(AdminKey keys)
        {
            userList.Add(keys);
        }
        public static AdminKey SignIn(AdminKey keys)
        {
            foreach (AdminKey storedUser in userList)
            {
                if (storedUser.GetAdminKey() == keys.GetAdminKey())
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[x];
                }
            }
            return item;
        }
        public static bool ReadDataFromFile(string adminKeyPath)
        {
            if (File.Exists(adminKeyPath))
            {
                StreamReader fileVariable = new StreamReader(adminKeyPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string key = ParseData(record, 1);                   
                    AdminKey keys = new AdminKey(key);
                    AddUserIntoList(keys);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }
        public static void StoreUserIntoFile(AdminKey keys, string adminKeyPath)
        {
            StreamWriter file = new StreamWriter(adminKeyPath, true);
            file.WriteLine(keys.GetAdminKey());
            file.Flush();
            file.Close();
        }

    }
}
