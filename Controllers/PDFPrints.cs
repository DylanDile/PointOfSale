using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class PDFPrints
    {
        public void printPDF()
        {
            string oldFile = "old.pdf";
            string newFile = "newFile.pdf"; 
            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);

            // open the writer
            FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            // the pdf content
            PdfContentByte cb = writer.DirectContent;

            // select the font properties
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 8);
            
            // write the text in the pdf content
            cb.BeginText();
            string text = "Some random blablablabla...";
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 520, 640, 0);
            cb.EndText();
            cb.BeginText();
            text = "Other random blabla...";
            // put the alignment and coordinates here
            cb.ShowTextAligned(2, text, 100, 200, 0);
            cb.EndText();

            // create the new page and add it to the pdf
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);
            // close the streams and voilá the file should be changed :)
            document.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }
   
        public void AnotherTest()
        {
            string originalFile = "old.pdf";
            string copyOfOriginal = "Copy.pdf";
            using (FileStream fs = new FileStream(originalFile, FileMode.Create, FileAccess.Write, FileShare.None))
            using (Document doc = new Document(PageSize.LETTER))
            using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
            {
                doc.Open();
                doc.Add(new Paragraph("Hi! I'm Original"));
                doc.Close();
            }
            PdfReader reader = new PdfReader(originalFile);
            using (FileStream fs = new FileStream(copyOfOriginal, FileMode.Create, FileAccess.Write, FileShare.None))
            // Creating iTextSharp.text.pdf.PdfStamper object to write
            // Data from iTextSharp.text.pdf.PdfReader object to FileStream object
            using (PdfStamper stamper = new PdfStamper(reader, fs)) { }
        }
    }
}
