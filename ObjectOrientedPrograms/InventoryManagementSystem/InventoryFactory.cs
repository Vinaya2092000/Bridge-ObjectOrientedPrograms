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
    public class InventoryFactory
    {
        InventoryManagements inventory = new InventoryManagements();
        public void ReadJsonFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var Json = reader.ReadToEnd();
                this.inventory = JsonConvert.DeserializeObject<InventoryManagements>(Json);
                Display(this.inventory.RiceList, "RiceList");
                Display(this.inventory.WheatList, "WheatList");
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }
        public void WriteToJson(string filepath)
        {
            var json = JsonConvert.SerializeObject(this.inventory);
            File.WriteAllText(filepath, json);
        }
        //Add new data into inventory
        public void AddInventory(string inventoryName, InventoryDetails details)
        {
            if (inventoryName == "RiceList")
            {
                this.inventory.RiceList.Add(details);
                Display(this.inventory.RiceList, "RiceList");
            }
            if (inventoryName == "WheatList")
            {
                this.inventory.WheatList.Add(details);
                Display(this.inventory.WheatList, "WheatList");
            }
            if (inventoryName == "PulsesList")
            {
                this.inventory.PulsesList.Add(details);
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }
        //delete inventory
        public void DeleteInventory(string inventoryName, string inventoryDetailsName)
        {
            if (inventoryName == "RiceList")
            {
                foreach (var data in this.inventory.RiceList)  // check condition in the list
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.RiceList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exist");
            }
            if (inventoryName == "WheatList")
            {
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.WheatList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exists");
            }
            if (inventoryName == "PulsesList")
            {
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.PulsesList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exists");
            }

        }
        public void EditInventory(string inventoryName, string inventoryDetailName)
        {
            Console.WriteLine("Enter RiceList/ WheatList/ PulsesList as input to Edit:");
            string InventoryName = Console.ReadLine();

            if (inventoryName == "RiceList")
            {
                Console.WriteLine("rice name to edit: ");
                string RiceList = Console.ReadLine();
                foreach (var data in this.inventory.RiceList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("Edit RiceList\n Enter: 1.Weight 2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Enter correct option");
                                break;
                        }
                    }
                }
            }
            if (inventoryName == "WheatList")
            {
                Console.WriteLine("Wheat name to edit");
                string Name = Console.ReadLine();
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("Edit WheatList\n Enter: 1.Weight 2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Enter correct option");
                                break;
                        }
                    }
                }
            }
            if (inventoryName == "PulsesList")
            {
                Console.WriteLine("Pulses name to edit: ");
                string Name = Console.ReadLine();
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("Edit PulsesList\n Enter: 1.Weight 2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Enter correct option");
                                break;
                        }
                    }
                }
                Console.WriteLine("Inventory does not exist");
            }
        }
        public void Display(List<InventoryDetails> list, string inventoryName)
        {
            Console.WriteLine("Inventory is:" + inventoryName);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "price");
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price);
            }
        }
    }
}
