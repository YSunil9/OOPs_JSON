using OOPs_Json.Json;

namespace OOPs_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management ");
            const string InventoryDataPath = @"D:\Bridgelab\repos\OOPs_Json\OOPs_Json\Json\Inventory.json";
            InventoryManagement inventoryData = new InventoryManagement();
            Console.WriteLine("1.Display\n");
            while (true)
            {
                Console.WriteLine("\nChoose your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        inventoryData.DisplayInventory(InventoryDataPath);
                        break;
                    default:
                        break;

                }
            }
        }
    }
}