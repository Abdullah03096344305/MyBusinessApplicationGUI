using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MyBusinessApplicationGUI.BL;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.DL
{
    class MUserDL
    {
        private static List<MUser> userList = new List<MUser>();
        public static void AddUserIntoList(MUser user)
        {
            userList.Add(user);
        }
        public static MUser SignIn(MUser user)
        {
            foreach (MUser storedUser in userList)
            {
                if (storedUser.GetUserName() == user.GetUserName() && storedUser.GetUserPassword() == user.GetUserPassword())
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
        public static bool ReadDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = ParseData(record, 1);
                    string userPassword = ParseData(record, 2);
                    MUser user = new MUser(userName, userPassword);
                    AddUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }
        public static void StoreUserIntoFile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.GetUserName() + "," + user.GetUserPassword());
            file.Flush();
            file.Close();
        }

    }
}
