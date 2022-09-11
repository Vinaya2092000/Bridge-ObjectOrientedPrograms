using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using ObjectOrientedPrograms.StockManagement;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.StockManagement
{
    public class StockManage
    {
        List<Stockm> stockList = new List<Stockm>();
        public void ReadJsonFileStock(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                this.stockList = JsonConvert.DeserializeObject<List<Stockm>>(json);
                Console.WriteLine("Name" + "\t" + "No of Shares" + "\t" + "Price Per Share");
                foreach (var data in stockList)
                {
                    Console.WriteLine(data.Name + "\t" + data.NoOfShares + "\t" + data.PricePerShare);
                }
            }
        }
    }
}
