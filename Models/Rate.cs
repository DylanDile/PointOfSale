using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class Rate
    {
        public int RateID { get; set; }
        public Decimal USDtoZWL { get; set; }
        public Decimal USDtoRAND { get; set; }
        public Decimal USDtoKWACHA { get; set; }
        public Decimal USDtoPULA { get; set; }
        public DateTime RateDate { get; set; }
        public string RateStatus { get; set; }
    }
}
