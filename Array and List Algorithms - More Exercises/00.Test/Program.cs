using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            int avaliableEnergy = int.Parse(Console.ReadLine());

            int lastIndex = inputList.Count ;
            string currentCommand = string.Empty;
            int currentInt = 0;
            
            for (int i = 0; i < inputList.Count; i++)
            {
                string currentStep = inputList[i];

                if (currentStep != "RabbitHole")
                {
                    currentCommand = TakeCommandString(currentStep);
                    currentInt = TakeCommandInt(currentStep);
                }
                               
                if (currentCommand == "Right")
                {
                    i = CalculateIndexRight(currentInt, i, lastIndex);
                    avaliableEnergy -= currentInt;
                }

                else if (currentCommand == "Left")
                {
                    i = CalculateIndexLeft(currentInt, i, lastIndex);
                    avaliableEnergy -= currentInt;
                }

                else if (currentCommand == "Bomb")
                {
                    inputList.RemoveAt(i);
                    avaliableEnergy -= currentInt;
                    i = 0;
                    if (avaliableEnergy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    
                }

                else if (currentStep == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                if (avaliableEnergy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                    break;
                }

                currentCommand = string.Empty;
                currentInt = 0;

                inputList.RemoveAt(inputList.Count-1);
                string newBomb = $"Bomb|{avaliableEnergy}";
                inputList.Add(newBomb);

            }
        }

        static string TakeCommandString(string currentStep) //Takes the command string.
        {
            string[] stringArrays = currentStep.Split('|').ToArray();
            return stringArrays[0];
        }

        static int TakeCommandInt(string currentStep) //Takes the command int.
        {
            string[] stringArrays = currentStep.Split('|').ToArray();
            int toInt = int.Parse(stringArrays[1]);
            return toInt;
        }

        static int CalculateIndexRight(int currentInt, int i, int lastIndex) // Calculates indes if outside of List boundaries.For "Right" commands.
        {
            int newIndex = 0;
            newIndex = (i + currentInt) % lastIndex;
            return newIndex;
            
        }

        static int CalculateIndexLeft(int currentInt, int i, int lastIndex) // Calculates indes if outside of List boundaries.For "Left" commands.
        {
            int newIndex = 0;
            int newIndexIfMoreThanZero = newIndex = i - currentInt;

            if (i - currentInt >= 0)
            {
                return newIndexIfMoreThanZero;
            }

            else 
            {
                int calculateLeft = 0;
                for (int j = 0; j < i; j++)
                {
                    calculateLeft++;
                }
                newIndex = (currentInt - calculateLeft) % lastIndex;
                return newIndex;
            }
                      
        }
    }
}
