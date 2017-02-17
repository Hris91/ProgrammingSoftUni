using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arreyOfStrings = Console.ReadLine().Split();
            int negativeCounter = arreyOfStrings.Length - 1;

            for (int i = 0; i <= arreyOfStrings.Length; i++)
            {
                if (arreyOfStrings[i] != arreyOfStrings[negativeCounter])
                {
                    Console.WriteLine("No");
                    return;
                }
                else 
                {
                    Console.WriteLine("Yes");
                    return;
                }

                
                    negativeCounter--;
                
            }
        }
    }
}
