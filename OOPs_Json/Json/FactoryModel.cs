using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Json.Json
{
    internal class FactoryModel
    {
        public List<InventoryModel> Rice { get; set; }
        public List<InventoryModel> Wheat { get; set; }
        public List<InventoryModel> Pulses { get; set; }
    }
}
