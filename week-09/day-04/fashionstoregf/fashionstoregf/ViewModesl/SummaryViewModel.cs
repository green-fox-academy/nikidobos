using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fashionstoregf.ViewModesl
{
    public class SummaryViewModel
    {
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double SubtotalPrice { get; set; }
    }
}
