using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Query { get; set; }

        public Website AddAWebsite(string line)
        {
            string[] tokens = line.Split(new[] {' ', '|', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Website currentWebsite = new Website()
            {
                Host = tokens[0],
                Domain = tokens[1],
                Query = new List<string>()
            };

            if (tokens.Length > 2)
            {
                for (int i = 2; i < tokens.Length; i++)
                {
                    currentWebsite.Query.Add(tokens[i]);
                }
            }
            else
            {
                currentWebsite.Query.Add("non");
            }

            return currentWebsite;
        }
    }
}
