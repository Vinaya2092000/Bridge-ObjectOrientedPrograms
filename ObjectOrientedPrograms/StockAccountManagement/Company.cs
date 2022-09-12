using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class Company
    {
        //public readonly List<Company> list;
        //public object? companyList { get; set; }
        public string? Symbol { get; set; }
        public int NoOfShares { get; set; }
        public int PricePerShare { get; set; }  

    }
}
