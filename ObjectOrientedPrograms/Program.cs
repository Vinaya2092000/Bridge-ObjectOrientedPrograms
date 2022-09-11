using ObjectOrientedPrograms.InventoryManagement;
namespace ObjectOrientedPrograms
{
    internal class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Object Oriented Problems");
            while (true)
            {
                Console.WriteLine("Select the programs\n 1.InventoryManagement");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}