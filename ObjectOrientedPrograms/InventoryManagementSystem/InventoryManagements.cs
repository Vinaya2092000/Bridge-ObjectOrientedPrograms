using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.InventoryManagementSystem
{
    public class InventoryManagements
    {
        public static string InventoryName { get; set; }
        public static string InventoryDetailsName { get; set; }
        public List<InventoryDetails>? RiceList { get; set; }
        public List<InventoryDetails>? WheatList { get; set; }
        public List<InventoryDetails>? PulsesList { get; set; }
    }
}
