using OOPs_Json.Json;

namespace OOPs_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management \n");
            //InventoryManagement json = new InventoryManagement();
            //json.Convert(@"D:\Bridgelab\repos\OOPs_Json\OOPs_Json\Json\Inventory.json");

            StockManagement obj = new StockManagement();
            obj.convert(@"D:\Bridgelab\repos\OOPs_Json\OOPs_Json\Json\Stock.json");
        }  
    }
}