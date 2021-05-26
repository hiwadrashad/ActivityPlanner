using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ActivityPlannerBlazor.Shared.PDF
{
    public class ITextSharpPdfCreator
    {
        public static string GeneratePDFAndReturnPath(string filename, string contenttext, string addition = "empty")
        {
            filename = filename + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.A4, 0f, 0f, 0f, 0f);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
            doc.Open();
            string storestring1 = contenttext;
            string addnewlines1 = storestring1.Replace("@", Environment.NewLine);
            Paragraph paragraph = new Paragraph();
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.PaddingTop = Element.ALIGN_MIDDLE;
            ColumnText column = new ColumnText(wri.DirectContent);
            column.SetSimpleColumn(new Rectangle((PageSize.A4.Width / 2) - 300, 0, PageSize.A4.Width, ((int)Math.Floor(PageSize.A4.Height / 1.5))));
            column.AddElement(paragraph);
            column.Go();
            doc.Close();
            var pathpdffile = Path.GetFullPath(filename);
            return pathpdffile;
        }
    }
}
