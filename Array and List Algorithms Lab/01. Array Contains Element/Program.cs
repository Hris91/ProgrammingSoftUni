﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToFind = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numberToFind == numbersArray[i])
                {
                    isFound = true;
                    break;
                }

            }
            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
