using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resisable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] resizableArray = new int[0];
            int elementCounter = 0;
            int lenght = 0;

            while (true)
            {
               
                string[] input = Console.ReadLine().Split(' ').ToArray();

                 if (input[0] == "end")
                {
                    break;
                }
                if (input.Length > 1)
                {
                    string numberInString = input[1];
                    int numberToPushOrIndex = NumberConverter(numberInString);

                    if (input[0] == "push")
                    {
                        lenght++;
                        Array.Resize(ref resizableArray, lenght);
                        resizableArray[elementCounter] = numberToPushOrIndex;
                        elementCounter++;
                    }
                    else if (input[0] == "removeAt")
                    {
                        int index = resizableArray[numberToPushOrIndex];
                        for (int i = index; i < resizableArray.Length - 1 ; i++)
                        {
                            resizableArray[i] = resizableArray[i + 1];
                        }
                        Array.Resize(ref resizableArray, lenght-1);
                        lenght--;
                        elementCounter--;
                        // resizableArray = resizableArray.Except(new int[] { resizableArray[Math.Abs(elementToRemove)] }).ToArray();


                    }
                }

                else if (input[0] == "pop")
                {
                    elementCounter--;
                    resizableArray = resizableArray.Except(new int[] {resizableArray[elementCounter]}).ToArray();
                    lenght--;

                }
                else if (input[0] == "clear")
                {
                    resizableArray = new int[0];
                    lenght = 0;
                    elementCounter = 0;               
                }
                
            }
            if (resizableArray.Length == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resizableArray));
            }
            
        }
        
        static int NumberConverter(string numberInString)
          {
              int n = int.Parse(numberInString);
              return n;
          }
    }
}
