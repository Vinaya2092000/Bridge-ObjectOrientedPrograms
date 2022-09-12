using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using ObjectOrientedPrograms.StockManagement;
using ObjectOrientedPrograms.StockAccountManagement;
using Stock = ObjectOrientedPrograms.StockAccountManagement.Stock;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\InventoryManagementSystem\InventoryDetails.json";
        const string STOCK_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\StockManagement\Stock.json";
        const string STOCK1_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\StockAccountManagement\Stock.json";
        const string COMPANY1_DATA_FILE_PATH = @"C:\Users\vinay\Documents\B-Practice\Bridge-OOPS\ObjectOrientedPrograms\StockAccountManagement\Company.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Object Oriented Problems");
            while (true)
            {
                Console.WriteLine("Select the programs\n 1.InventoryManagement\n 2.InventoryManagementSystem\n 3.StockManagement\n 4.StockAccountManagement");
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
                    case 3:
                        StockManage stockManage = new StockManage();
                        stockManage.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                        break;
                    case 4:
                        StockManagements manage = new StockManagements();
                        manage.ReadJsonFileStock(STOCK1_DATA_FILE_PATH);
                        manage.ReadJsonFileCompany(COMPANY1_DATA_FILE_PATH);
                        Company company = new Company()
                        //Stock stock = new Stock()
                        {
                            Symbol = "PalmTree",
                            NoOfShares = 30,
                            PricePerShare = 880,
                        };
                        //manage.SellStockShares(stock);
                        manage.BuyCompanyShares(company);
                        manage.WriteToJsonStock(STOCK1_DATA_FILE_PATH);
                        manage.WriteToJsoncompany(COMPANY1_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}