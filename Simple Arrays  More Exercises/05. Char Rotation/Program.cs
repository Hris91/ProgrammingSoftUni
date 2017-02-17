using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {     

        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] symbols = numberInput.ToCharArray();           
           
            int currentChar = 0;

         
          
          
            for (int i = 0; i < symbols.Length; i++)
            {
                currentChar = symbols[i];
                if (numbers[i] % 2 != 0)
                {
                    currentChar += numbers[i];
                    Console.Write((char)currentChar);
                }

                else 
                {
                    currentChar -= numbers[i];
                    Console.Write((char)currentChar);
                }
               
                
            }
          

            
        }
    }
}
