using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class UserModel
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string username { get; set; }
        public string ecnum { get; set; }
        public string occupation { get; set; }
        public string password { get; set; }

        public string status { get; set; }
        public string loggedUser { get; set; }       
        
    }
}
