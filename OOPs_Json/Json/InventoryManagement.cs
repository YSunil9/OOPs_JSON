using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Json.Json
{
    internal class InventoryManagement
    {
        InventoryModel model = new InventoryModel();
        List<InventoryModel> list = new List<InventoryModel>();
        public void Convert(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
                Console.WriteLine("Items   Price   Weight    TotalValue");
                foreach (var objects in items)
                {
                    double value = objects.PricePerKg * objects.Weight;
                    Console.WriteLine(objects.Name + "\t" + objects.Weight + "\t" + objects.PricePerKg + "\t\t" + (objects.Weight * objects.PricePerKg));
                   // Console.WriteLine(objects.Name + " -> " + objects.PricePerKg + " -> " + objects.Weight + " -> " + value);
                }
            }
        }
    }
}