using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Altitude_second_Attempt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandsArray = Console.ReadLine().Split();

            double altutude = double.Parse(commandsArray[0]);
            string currentInput = string.Empty;
            string currentCommand = string.Empty;
            double currentNumber = 0;
            bool up = false;
            bool down = false;

            for (int i = 1; i < commandsArray.Length; i++)
            {
                currentInput = commandsArray[i];

                bool checkIfInt = currentInput.All(Char.IsDigit);

                if (checkIfInt == false)
                {
                    currentCommand = commandsArray[i];
                    
                }
                else
                {
                    currentNumber = double.Parse(currentInput);
                }

                if (currentCommand == "up")
                {
                    up = true;
                }
                else if (currentCommand == "down")
                {
                    down = true;
                }

                if (up == true && i % 2 == 0)
                {
                    altutude += currentNumber;
                    up = false;
                }
                else if (down == true && i % 2 == 0)
                {
                    altutude -= currentNumber;
                    down = false;
                }


            }

            if (altutude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altutude}m");
            }



        }
    }
}
