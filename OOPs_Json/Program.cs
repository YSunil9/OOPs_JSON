using OOPs_Json.Json;

namespace OOPs_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management \n");
            InventoryManagement json = new InventoryManagement();
            json.convert(@"D:\Bridgelab\repos\OOPs_Json\OOPs_Json\Json\Inventory.json");
        }  
    }
}