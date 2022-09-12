using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.StockManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using Newtonsoft.Json;
namespace ObjectOrientedPrograms.StockManagement
{
    public class Stock
    {
        public string? Name { get; set; }
        public int NoOfShares { get; set; }
        public int PricePerShare { get; set; }

        
    }
}

