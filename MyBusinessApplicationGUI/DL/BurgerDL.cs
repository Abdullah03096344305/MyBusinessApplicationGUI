using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBusinessApplicationGUI.BL;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MyBusinessApplicationGUI.DL
{
    class BurgerDL
    {
        public static List<Burger> burgers = new List<Burger>();
        public static void AddBurgerIntoList(Burger burger, ListView listView)
        {
            burgers.Add(burger);
            AddBurgerIntoListView(burger, listView);
        }       
        public static void AddBurgerIntoListView(Burger burger, ListView listView)
        {
            ListViewItem item = new ListViewItem(burger.GetBurgerName());
            item.SubItems.Add(burger.GetBurgerPrice().ToString());
            listView.Items.Add(item);
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
        public static bool ReadBurgerFile(string burgerPath, ListView listView)
        {
            if (File.Exists(burgerPath))
            {
                StreamReader fileVariable = new StreamReader(burgerPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string burgerName = ParseData(record, 1);
                    string burgerPrice = ParseData(record, 2);
                    int price = int.Parse(burgerPrice);
                    Burger burger = new Burger(burgerName, price);
                    AddBurgerIntoList(burger, listView);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void StoreUserIntoFile(Burger burgers, string burgerPath)
        {
            StreamWriter file = new StreamWriter(burgerPath, true);
            file.WriteLine(burgers.GetBurgerName() + "," + burgers.GetBurgerPrice());
            file.Flush();
            file.Close();
        }

    }
}
