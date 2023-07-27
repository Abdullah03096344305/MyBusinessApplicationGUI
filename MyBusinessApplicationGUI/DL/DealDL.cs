using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MyBusinessApplicationGUI.BL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBusinessApplicationGUI.DL
{
    class DealDL
    {
        public static List<Deals> deals = new List<Deals>();
        public static void AddDealIntoList(Deals deal, ListView listView)
        {
            deals.Add(deal);
            AddDealIntoListView(deal, listView);
        }
        public static void AddDealToList(Deals deal)
        {
            deals.Add(deal);
        }
        public static List<Deals> GetDeals()
        {
            return deals;
        }
        public static void RemoveDealFromList(string dealName, int dealPrice)
        {
            Deals dealToRemove = deals.FirstOrDefault(d => d.GetDealName() == dealName && d.GetDealPrice() == dealPrice);
            if (dealToRemove != null)
            {
                deals.Remove(dealToRemove);
            }
        }

        public static void AddDealIntoListView(Deals deal, ListView listView)
        {
            ListViewItem item = new ListViewItem(deal.GetDealName());
            item.SubItems.Add(deal.GetDealPrice().ToString());
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

        public static bool ReadDealFile(string dealPath)
        {
            if (File.Exists(dealPath))
            {
                deals.Clear();
                StreamReader fileVariable = new StreamReader(dealPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string dealName = ParseData(record, 1);
                    string dealPrice = ParseData(record, 2);
                    int price = int.Parse(dealPrice);
                    Deals deal = new Deals(dealName, price);
                    AddDealToList(deal);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void StoreUserIntoFile(Deals deals, string dealPath)
        {
            StreamWriter file = new StreamWriter(dealPath, true);
            file.WriteLine(deals.GetDealName() + "," + deals.GetDealPrice());
            file.Flush();
            file.Close();
        }
        public static void UpdateDealFile(string dealPath)
        {
            using (StreamWriter file = new StreamWriter(dealPath, false))
            {
                foreach (var deal in deals)
                {
                    file.WriteLine(deal.GetDealName() + "," + deal.GetDealPrice());
                }
                file.Flush();
            }
        }
        
    
    }
}
