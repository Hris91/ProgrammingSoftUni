using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

        public Snake CreateASnake(string line)
        {
            string[] tokens = line.Split(' ').ToArray();

            return new Snake()
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                CrueltyCoefficient = int.Parse(tokens[3])
            };
        }
    }
}
