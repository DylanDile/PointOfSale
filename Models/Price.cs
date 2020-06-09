using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class Price
    {
        public int PriceID { get; set; }
        public int ProID { get; set; }
        public string Barcode { get; set; }
        public decimal PriceNew { get; set; }
        public DateTime PriceDate { get; set; }
        public int AddedBy { get; set; }
        public string PriceStatus { get; set; }
    }
}