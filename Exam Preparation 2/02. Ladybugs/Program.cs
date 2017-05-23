using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());

            List<int> ladyBugsIndexes = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] field = new int[sizeOfTheField];

            foreach (var index in ladyBugsIndexes)
            {
                if (index < 0 || index >= field.Length)
                {
                    continue;
                }
                field[index] = 1;               
            }
                      
            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] tokens = inputCommand.Split(' ');

                int ladybugCurrentIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);
                int position = ladybugCurrentIndex;

                if (position < 0 || position >= field.Length)
                {
                    continue;
                }

                if (field[ladybugCurrentIndex] == 0)
                {
                    continue;
                }

               
                field[ladybugCurrentIndex] = 0;

                while (true)
                {
                    
                    if (direction == "right")
                    {
                        position += flyLenght;
                    }
                    else
                    {
                        position -= flyLenght;
                    }
                    if (position  < 0 || position  >= field.Length)
                    {
                        break;
                    }
                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }

                    
                }
                inputCommand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" " ,field));
            
        }
    }
}
