using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
namespace ObjectOrientedPrograms
{
    internal class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\InventoryManagementSystem\InventoryDetails.json";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Object Oriented Problems");
            while (true)
            {
                Console.WriteLine("Select the programs\n 1.InventoryManagement\n 2.InventoryManagementSystem");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        InventoryFactory inventoryFactory = new InventoryFactory();
                        inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                        InventoryDetails details = new InventoryDetails()
                        {
                            Name = "Boiled",
                            Weight = 10,
                            Price = 20,
                        };
                        inventoryFactory.AddInventory("RiceList", details);
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        inventoryFactory.DeleteInventory("RiceList", "Boiled");
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        inventoryFactory.EditInventory("RiceList", "Boiled");
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}