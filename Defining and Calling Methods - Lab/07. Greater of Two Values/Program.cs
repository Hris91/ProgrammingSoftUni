﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int first , int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first , char second)
        {
            if(first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first , string second)

        {
            int firstToInteger = first.CompareTo(second);
            int secondToInteger = second.CompareTo(first);
            if (firstToInteger >= secondToInteger)
            {
                return first;
            }
            else
            {
                return second;
            }
           
            
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }

            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);

            }

            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }

        }
    }
}
