using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace _02.HTML_Contents
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");    
                 
            List<string> htmlFile = new List<string>() {"<!DOCTYPE html>", "<html>", "<head>", "</head>", "<body>", "</ body >", "</html>"};

            List<string> bodyParts = new List<string>();

            string tittle = string.Empty;

            foreach (var line in lines)
            {
                if (line == "exit")
                {
                    break;
                }

                string[] newLine = line.Split(' ').ToArray();
                string tag = newLine[0];
                string content = newLine[1];

                if (newLine[0] != "title")
                {
                    bodyParts.Add($"\t<{tag}>{content}</{tag}>");
                }
                else
                {
                    tittle = $"\t<title>{content}</title>";
                }              
            }      
            
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<!DOCTYPE html>");
            builder.AppendLine("<html>");
            builder.AppendLine("<head>");
            if (tittle != string.Empty)
            {
                builder.AppendLine(tittle);
            }
            builder.AppendLine("</head>");
            builder.AppendLine("<body>");
            if (bodyParts.Any())
            {
                foreach (var part in bodyParts)
                {
                    builder.AppendLine(part);
                }
            }
            builder.AppendLine("</ body >");
            builder.Append("</html>");

            Console.WriteLine(builder.ToString());
            File.WriteAllText("result.html", builder.ToString());
        }
        
    }
}
