using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPrograms.StockManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using Newtonsoft.Json;
namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class Stock
    {
        //public readonly List<Stock> list;
        //public object? stockList { get; set; }    
        public string? Name { get; set; }
        public int? NoOfShares { get; set; }
        public int? PricePerShare { get; set; }

        
    }
}

