using PointOfSale.Company;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Controls
{
    class PrintFiscal
    {
        ClassCompany cc = new ClassCompany();
        PrintDocument pdoc = null;     
        private int userID;
        private IList<Cart> items;
        public PrintFiscal(int userID, IList<Cart> items)
        {
            this.userID = userID;
            this.items = items;
        }

        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
           

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            DataTable dt = new DataTable();
            DataRow row = cc.getCompanyInfo();

            string companyName = row["ccName"].ToString();
            string address = row["ccAddress"].ToString();
            string telephone = row["ccPhone"].ToString();
            string invoiceNum = "INV1001201";
            string printedBy = "Dylan Mukoko";
            string DatePrinted = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            graphics.DrawString(companyName, new Font("Courier New", 11, FontStyle.Bold),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);          

            Offset = Offset + 20;
            graphics.DrawString(address, new Font("Courier New", 10),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 50;
            graphics.DrawString("Tel : \t\t" + telephone, new Font("Courier New", 10, FontStyle.Italic),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Invoice Date : \t" + DatePrinted , new Font("Courier New", 10),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Printed By:\t\t"+ printedBy, new Font("Courier New", 10),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Invoice Number : \t\t" + invoiceNum, new Font("Courier New", 10, FontStyle.Bold),
                                new SolidBrush(Color.Red), startX, startY + Offset);

            Offset = Offset + 10;
            var sb = new StringBuilder();
            sb.AppendLine("Purchased Items :");
            sb.AppendLine("====================");            

            const int FIRST_COL_PAD = 20;
            const int SECOND_COL_PAD = 7;
            const int THIRD_COL_PAD = 20;
            const int RIGHT_ALIGN_PAD = 55;
            const int RIGHT_ALIGN_BEFORE = 50;

            string itemName = "Product Name ";
            string qtyAndPrice = "\tQty x Price";
            sb.Append(itemName.PadRight(FIRST_COL_PAD));            
            sb.Append(qtyAndPrice.PadRight(SECOND_COL_PAD));
            sb.AppendLine(string.Format("Total").PadLeft(15));
            decimal GrossTotal = 0.00m;
            foreach (var item in this.items)
            {
                sb.Append(item.ProName.PadRight(FIRST_COL_PAD));
                var breakDown = item.TotalPrice > 0 ? item.Quantity + "x" + Math.Round(item.Price, 2) : string.Empty;
                sb.Append("\t" +breakDown.PadRight(SECOND_COL_PAD));
                sb.AppendLine(string.Format("$ {0:0.00}", item.TotalPrice).PadLeft(THIRD_COL_PAD));
                GrossTotal += item.TotalPrice;
            }
            sb.AppendLine(string.Format("============").PadLeft(RIGHT_ALIGN_PAD));
            sb.AppendLine(string.Format("\t\tTotal: $ {0:0.00}", GrossTotal).PadLeft(RIGHT_ALIGN_BEFORE));
   

            sb.AppendLine("=================================================");
            sb.AppendLine("\tThank you for doing business with us");

            Offset = Offset + 20;
            graphics.DrawString(sb.ToString(), new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            
        }
    }
}
