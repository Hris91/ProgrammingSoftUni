using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }

        public Dog CreateADog(string line)
        {
            string[] tokens = line.Split(' ').ToArray();

            return new Dog()
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                NumberOfLegs = int.Parse(tokens[3])
            };
        }
    }
}
