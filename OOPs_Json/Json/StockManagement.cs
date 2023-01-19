using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Json.Json
{
    internal class StockManagement
    {
        StockModel model = new StockModel();
        List<StockModel> stockList = new List<StockModel>();
        public void convert(string jasonFilePath)
        {
            using (StreamReader reader = new StreamReader(jasonFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                Console.WriteLine("Name" + "\t" + "        Number" + "\t" + "Price" + "\t" + "        TotalPrice");
                foreach (var item in items)
                {
                    Console.WriteLine(item.stockNames + "\t" + item.numberOfShare + "\t" + item.sharePrice + "\t\t" + (item.numberOfShare * item.sharePrice));
                   // Console.WriteLine(item.stockNames + " " + item.numberOfShare + " " + item.sharePrice);
                }

            }
        }
    }
}
