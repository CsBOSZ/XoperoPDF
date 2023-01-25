using iTextSharp.text;
using iTextSharp.text.pdf;
using xopPDF.elements;


void tak(ref Document doc,string t = "tak")
 {
     
     doc.Add(new Paragraph("tak"));
     
 }

 using FileStream fs = new FileStream("/home/bogusz/RiderProjects/xopPDF/xopPDF/output.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
 {
     Document doc = new Document();

     using PdfWriter writer = PdfWriter.GetInstance(doc, fs);
     doc.Open();
     //File.ReadAllText("/home/bogusz/RiderProjects/xopPDF/xopPDF/input.txt")
     doc.DocAdd("//CR tak adam //C|245|41|245 //S|50 tak mi //CR //SR tak \nnie");

     doc.Close();
 }

