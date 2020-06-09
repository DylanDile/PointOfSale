using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class Stock
    {
        public int StockID { get; set; }
        public int ProID { get; set; }        
        public string Barcode { get; set; }
        public long Quantity { get; set; }
        public string StockStatus { get; set; }
    }
}
