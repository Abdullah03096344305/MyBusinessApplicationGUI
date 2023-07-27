using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MyBusinessApplicationGUI.BL;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.DL
{
    class UserReveiwDL
    {
        public static List<UserReveiw> userReveiws = new List<UserReveiw>();
        public static void AddReveiwIntoList(UserReveiw user)
        {
            userReveiws.Add(user);
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
                userReveiws.Clear();
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = ParseData(record, 1);
                    string userNumber = ParseData(record, 2);
                    string userRating = ParseData(record, 1);
                    string userMessage = ParseData(record, 2);
                    int Number = int.Parse(userNumber);
                    int Rating = int.Parse(userRating);
                    UserReveiw user = new UserReveiw(userName, Number,Rating, userMessage);
                    AddReveiwIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }
        public static void StoreUserIntoFile(UserReveiw user, string Reveiwpath)
        {
            StreamWriter file = new StreamWriter(Reveiwpath, true);
            file.WriteLine(user.GetName() + "," + user.GetNumber() + "," + user.GetRating() + "," + user.GetMessage());
            file.Flush();
            file.Close();
        }




    }
}
