using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterValue = Console.ReadLine();
            int[] arrayOfInts = enterValue.Split(' ').Select(int.Parse).ToArray();
            bool ifBigger = false;


            for (int i = 1; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] > arrayOfInts[i-1])
                {
                    ifBigger = true;
                }
                else
                {
                    ifBigger = false;
                    Console.WriteLine("No");
                    break;
                }
            }

            if (ifBigger == true)
            {
                Console.WriteLine("Yes");
            }

           
          
            
           

            

        }
    }
}
