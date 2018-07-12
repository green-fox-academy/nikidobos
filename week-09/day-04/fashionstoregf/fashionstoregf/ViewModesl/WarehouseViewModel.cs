using fashionstoregf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fashionstoregf.ViewModesl
{
    public class WarehouseViewModel
    {
        public List<Warehouse> Warehouses { get; set; }
        public List<string> Sizes { get; set; }
        public List<string> ItemNames { get; set; }
    }
}
