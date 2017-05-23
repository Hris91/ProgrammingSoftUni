using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }

        public Cat CreateACat(string line)
        {
            string[] tokens = line.Split(' ').ToArray();

            return new Cat()
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                IntelligenceQuotient = int.Parse(tokens[3])
            };
        }
    }
}
