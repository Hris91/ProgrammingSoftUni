using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var websites = new List<Website>();

            while (line != "end")
            {
                Website currentWebsite = new Website();
                currentWebsite = currentWebsite.AddAWebsite(line);
                websites.Add(currentWebsite);

                line = Console.ReadLine();
            }
                        
            foreach (var website in websites)
            {
                if (website.Query.Contains("non"))
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
                else
                {
                    website.Query = website.Query.Select(x => "[" + x + "]").ToList();
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?={string.Join("&",website.Query)}");
                }
            }
        }
    }
}
