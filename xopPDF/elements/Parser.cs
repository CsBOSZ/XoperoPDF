using iTextSharp.text;

namespace xopPDF.elements;

public static class Parser
{
    private static Dictionary<string, Action> _actions = new Dictionary<string, Action>();

    public static void onEvent(this string str)
    {
        foreach (var kv in _actions)
        {
            if (str.StartsWith(kv.Key))
            {
                kv.Value();
            }
        }
    }
   public static void DocAdd(this Document doc,string str)
   {
       var fs = new Font();
       var f = new Font();
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

                   switch (s1[2])
                   {
                       case 'C':

                           if (s1[3]=='R')
                           {
                               if (s1.Length == 5 && s1[4] == 's')
                                   fs = new Font();
                               else
                                   f = fs;
                           }
                           else
                           {
                               var argsc = s1.Split('|');
                               if (argsc.Length == 4)
                               {
                                   try
                                   {
                                       if (argsc[0] == "s")
                                           fs.Color = new BaseColor(
                                               int.Parse(argsc[1]), 
                                               int.Parse(argsc[2]),
                                               int.Parse(argsc[3]));
                                       else
                                           f.Color = new BaseColor(
                                               int.Parse(argsc[1]), 
                                               int.Parse(argsc[2]),
                                               int.Parse(argsc[3]));
                                   }
                                   catch (Exception e)
                                   {
                                       Console.WriteLine(e);
                                   }
                               }
                           }
                           
                           break;
                   }
               }
               else
               {
                   p.Add(new Chunk(s1+" ",f));
               }
               
           }

           doc.Add(new Paragraph(p));
       }
   }

   
}