using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputsList = new List<string>();
            var elements = new List<Element>();
            
            while (input != "collapse")
            {
                inputsList.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < inputsList.Count; i+=2)
            {
                Element currentElement = new Element();
                currentElement.State = inputsList[i];
                currentElement.Fiction = inputsList[i + 1];

                elements.Add(currentElement);

            }

            foreach (var element in elements)
            {
                string state = element.State;
                string fiction = element.Fiction;
                
                while (fiction != string.Empty)
                {                   
                    state = state.Replace(fiction, "");            
                   
                    if (fiction.Length >= 3)
                    {
                        fiction = fiction.Remove(0, 1);
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                    else
                    {
                        fiction = string.Empty;
                    }
                   
                }
                if (state != string.Empty)
                {
                    Console.WriteLine(state.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }
               
            }
        }
    }
}
