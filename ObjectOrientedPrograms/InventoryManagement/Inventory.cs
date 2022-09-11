using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPrograms.InventoryManagement;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.InventoryManagement
{
    public class Inventory
    {
        InventoryDetails inventory = new InventoryDetails();
        //creating list 
        List<InventoryDetails> details = new List<InventoryDetails>();
        public void ReadJsonFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                // DeserializeObject it converts JSON string to custom . Net object.
                this.details = JsonConvert.DeserializeObject<List<InventoryDetails>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "Price");
                foreach (var data in details)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price);
                }
            }
        }
    }
}
