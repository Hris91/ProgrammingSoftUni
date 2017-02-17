using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Balistic_training
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCordinates = Console.ReadLine();
            int[] cordinates = inputCordinates.Split(' ').Select(int.Parse).ToArray();

            string[] inputCommands = Console.ReadLine().Split(' ');

            int x = cordinates[0];
            int y = cordinates[1];
            int newX = 0;
            int newY = 0;
           

            string currentInput = string.Empty;
            string currentCommand = string.Empty;
            int currentInt = 0;


            for (int i = 1; i < inputCommands.Length ; i++)
            {
                currentInput = inputCommands[i];
                bool isItANumber = int.TryParse(currentInput , out currentInt);

                if (i == 1)
                {
                    currentCommand = inputCommands[0];
                }
               
                if (isItANumber == false)
                {
                    currentCommand = inputCommands[i];
                }
                                            

                if (currentCommand == "right" && i % 2 != 0)
                {
                    newX += currentInt;
                }
                else if (currentCommand == "left" && i % 2 != 0)
                {
                    newX -= currentInt;
                }
                else if (currentCommand == "up" && i % 2 != 0)
                {
                    newY += currentInt;
                }
                else if (currentCommand == "down" && i % 2 != 0)
                {
                    newY -= currentInt;
                }

            }
            Console.WriteLine($"firing at [{newX}, {newY}]");
            if (newX == x && newY == y)
            {
                Console.WriteLine("got 'em!");
            }
            else 
            {
                Console.WriteLine("better luck next time...");
            }
            //Console.WriteLine(newX);
            //Console.WriteLine(newY);
        }
    }
}
