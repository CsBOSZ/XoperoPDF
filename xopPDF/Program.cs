using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using xopPDF.elements;
Console.Write("input path:");
var input = Console.ReadLine(); ///home/bogusz/RiderProjects/xopPDF/xopPDF/input.txt
Console.Write("output path:");                              
var output = Console.ReadLine() ?? Environment.CurrentDirectory; ///home/bogusz/RiderProjects/xopPDF/xopPDF


 using FileStream fs = new FileStream(output + "/output.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
 {
     Document doc = new Document();

     using PdfWriter writer = PdfWriter.GetInstance(doc, fs);
     doc.Open();
     //

     if (input != null) doc.DocAdd(File.ReadAllText(input));
      
     doc.Close();
 }

