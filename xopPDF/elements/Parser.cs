using iTextSharp.text;

namespace xopPDF.elements;

public static class Parser
{

    
    
   public static void DocAdd(this Document doc,string str)
   {
       Font f = new Font();
       string[] tabstr = str.Split("\n");

       foreach (var s in tabstr)
       {
           Phrase p = new Phrase();

           string[] c = s.Split(" ");
           
           foreach (var s1 in c)
           {
               if (s1.StartsWith("//"))
               {
                   var arg = s1.Substring(3);
                   p.Add(arg+" ");
               }
               else
               {
                   p.Add(s1+" ");
               }
               
           }

           doc.Add(new Paragraph(p));
       }
   }

   
}