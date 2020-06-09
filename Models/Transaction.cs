using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class Transaction
    {
        public int TransID  { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public string TransQuery { get; set; }
        public string Retry { get; set; }
        public string TransStatus { get; set; }

    }
}
