using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class Connection
    {
        public string connection = ConfigurationManager.ConnectionStrings["POS"].ConnectionString;

    }
}
