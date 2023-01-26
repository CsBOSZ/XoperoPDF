
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace xopPDF.elements;

public static class Parser
{
    
    private static Font fs = new Font(Font.FontFamily.HELVETICA, 24);
    private static Font h1 = new Font(Font.FontFamily.HELVETICA, 64);
    private static Font h2 = new Font(Font.FontFamily.HELVETICA, 32);
    private static Font h3 = new Font(Font.FontFamily.HELVETICA, 28);
    private static string a = "";
     private static Font f = new Font(Font.FontFamily.HELVETICA, 24);
    private static Dictionary<string, Action<string>> _actions = new Dictionary<string, Action<string>>()
    {
        
                {"RRR", (string arg) =>
                    {
                        
                        f = new Font(Font.FontFamily.HELVETICA, 24);
                        
                    }
                },
                {"RR", (string arg) =>
                    {

                        f.Size = fs.Size;
                        f.Color = fs.Color;

                    }
                },
                 {"CR", (string arg) =>
                       {
                
                           f.Color = fs.Color;
                
                       }
                 },
         
               {"|CR", (string arg) =>
                    {
            
                       fs.Color = BaseColor.BLACK;
            
                    }
                   
               },
               
               {"CS>", (string arg) =>
                   {
                       var args = arg.Split("|");

                       if (int.TryParse(args[0], out var arg1))
                       {
                           if (int.TryParse(args[1], out var arg2))
                           {
                               if (int.TryParse(args[2], out var arg3))
                               {
                                    f.Color = new BaseColor(arg1,arg2,arg3);
                               }
                           }
                       }
                   }
                   
               },
               
               {"|CS>", (string arg) =>
                   {
                       var args = arg.Split("|");

                       if (int.TryParse(args[0], out var arg1))
                       {
                           if (int.TryParse(args[1], out var arg2))
                           {
                               if (int.TryParse(args[2], out var arg3))
                               {
                                   fs.Color = new BaseColor(arg1,arg2,arg3);
                               }
                           }
                       }
                   }
                   
               },
               {"SR", (string arg) =>
                   {
                
                       f.Size = fs.Size;
                
                   }
               },
         
               {"|SR", (string arg) =>
                   {
            
                       fs.Size = 24;
            
                   }
               },
               {"SS>", (string arg) =>
                   {
                       if (int.TryParse(arg, out var arg1))
                       {
                           f.Size = arg1;
                       }
                   }
                   
               },
               {"|SS>", (string arg) =>
                   {
                       if (int.TryParse(arg, out var arg1))
                       {
                           fs.Size = arg1;
                       }
                   }
                   
               },
               {"|HCS>", (string arg) =>
                   {
                       
                       var args = arg.Split("|");
                       if (int.TryParse(args[0], out var arg1))
                       {
                           if (int.TryParse(args[1], out var arg2))
                           {
                               if (int.TryParse(args[2], out var arg3))
                               {
                                   if (int.TryParse(args[3], out var arg4))
                                   {
                                       switch (arg1)
                                       {
                                           case 1:
                                               h1.Color = new BaseColor(arg2,arg3,arg4);
                                               break;
                                           case 2:
                                               h2.Color = new BaseColor(arg2,arg3,arg4);
                                               break;
                                           case 3:
                                               h3.Color = new BaseColor(arg2,arg3,arg4);
                                               break;
                                       }
                                   }
                               }
                           }
                       }
                   }
                   
               },
               {"|HSS>", (string arg) =>
                   {

                       
                       var args = arg.Split("|");
                       if (int.TryParse(args[0], out var arg1))
                       {
                           if (int.TryParse(args[1], out var arg2))
                           {
                              
                                       switch (arg1)
                                       {
                                           case 1:
                                               h1.Size = arg2;
                                               break;
                                           case 2:
                                               h2.Size = arg2;
                                               break;
                                           case 3:
                                               h3.Size = arg2;
                                               break;
                                       }
                               
                           }
                       }
                   }
                   
               },
               {"|HCR>", (string arg) =>
                   {
                       
                       if (int.TryParse(arg[0].ToString(), out var arg1))
                       {
                           
                                       switch (arg1)
                                       {
                                           case 1:
                                               h1.Color = BaseColor.BLACK;
                                               break;
                                           case 2:
                                               h2.Color = BaseColor.BLACK;
                                               break;
                                           case 3:
                                               h3.Color = BaseColor.BLACK;
                                               break;
                                       }
                               
                       }
                   }
                   
               },
               {"|HSR>", (string arg) =>
                   {
                       if (int.TryParse(arg[0].ToString(), out var arg1))
                       {
                           
                              
                                       switch (arg1)
                                       {
                                           case 1:
                                               h1.Size = 64;
                                               break;
                                           case 2:
                                               h2.Size = 32;
                                               break;
                                           case 3:
                                               h3.Size = 28;
                                               break;
                                       }
                               
                           
                       }
                   }
                   
               },
               {"|HRR>", (string arg) =>
                   {
                       if (int.TryParse(arg[0].ToString(), out var arg1))
                       {
                           
                              
                           switch (arg1)
                           {
                               case 1:
                                   h1.Size = 64;
                                   h1.Color = BaseColor.BLACK;
                                   break;
                               case 2:
                                   h2.Size = 32;
                                   h1.Color = BaseColor.BLACK;
                                   break;
                               case 3:
                                   h3.Size = 28;
                                   h1.Color = BaseColor.BLACK;
                                   break;
                           }
                               
                           
                       }
                   }
                   
               },
               {"H", (string arg) =>
                   {
                       if (int.TryParse(arg[0].ToString(), out var arg1))
                       {
                           
                              
                           switch (arg1)
                           {
                               case 1:
                                   f.Size = h1.Size;
                                   f.Color = h1.Color;
                                   break;
                               case 2:
                                   f.Size = h2.Size;
                                   f.Color = h2.Color;
                                   break;
                               case 3:
                                   f.Size = h3.Size;
                                   f.Color = h3.Color;
                                   break;
                           }
                               
                           
                       }
                   }
                   
               },
               {"AS>", (string arg) =>
                   {
                       a = arg;
                   }
                   
               },
               {"AR", (string arg) =>
                   {
                       a = "";
                   }
                   
               },
              
               
               
    };
    
    public static void onEvent(this string str)
    {
        foreach (var kv in _actions)
        {
            if (str.StartsWith(kv.Key))
            {
                kv.Value(str[kv.Key.Length..]);
                break;
            }
        }
    }
   public static void DocAdd(this Document doc,string str)
   {
       
       fs = new Font(Font.FontFamily.HELVETICA, 24);
       f = new Font(Font.FontFamily.HELVETICA, 24);
      _actions.Add("IMG>", (string arg) =>
          {
              var args = arg.Split("|");
              var img = Image.GetInstance(args[0]);
              if (float.TryParse(args[1],out var arg1))
              {
                  if (float.TryParse(args[2],out var arg2))
                  {
                      img.ScaleAbsolute(arg1,arg2);
                  }
              }
              doc.Add(img);
          }
      );
      _actions.Add("TAB>", (string arg) =>
          {
              var args = arg.Split("|");
              
              if (!int.TryParse(args[0], out var arg1)) return;
              if (!int.TryParse(args[1], out var arg2)) return;
              
              PdfPTable table = new PdfPTable(arg2);
              table.WidthPercentage = arg1;
              
              foreach (var s in args.Skip(2))
              {

                  table.AddCell(s);

              }
              
              doc.Add(table);
              
          }
      );
      _actions.Add("AUTHOR>", (string arg) =>
          {
              doc.AddAuthor(arg);
          }
      );
      _actions.Add("TITLE>", (string arg) =>
          {
              doc.AddTitle(arg);
          }
      );
      foreach (var keyValuePair in _actions)
      {
          Console.WriteLine(keyValuePair.Key);
      }
       
       
       string[] tabstr = str.Split("\n");

       foreach (var s in tabstr)
       {
           Phrase p = new Phrase();

           string[] c = s.Split(" ");
           
           foreach (var s1 in c)
           {
               if (s1.StartsWith("//"))
               {
                   var arg = s1[2..];
                    
                    arg.onEvent();
               }
               else
               {
                   var ccc = new Chunk(s1 + " ", new Font(f.Family,f.Size,f.Style,f.Color));
                   if (a!="")
                   {
                       ccc.SetAnchor(a);
                   }
                   p.Add(ccc);
               }
               
           }

           doc.Add(new Paragraph(p));
           
       }
   }

   
}