using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class Product
    {
        public int ProID { get; set; }
        public string Barcode { get; set; }
        public string ProName { get; set; }
        public String ProCategory { get; set; }
        public string ProBrand { get; set; }
        public string ProTag { get; set; }
        public string FrontCameraPXL { get; set; }
        public string BackCameraPXL { get; set; }
        public string ScreenSize { get; set; }
        public string ProOS { get; set; }
        public string ProRam { get; set; }
        public string ProROM { get; set; }
        public string SerialNumber { get; set; }
        public string OtherInfor { get; set; }
        public DateTime DateAdded { get; set; }
        public string  ProStatus { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string total { get; set; }      

        public DataTable dataTable { get; set; } = new DataTable();
    }
}
