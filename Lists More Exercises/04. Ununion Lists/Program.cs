using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberOfNewLists = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNewLists; i++)
            {
                List<int> listsToCompare = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> differentNumbers = listsToCompare.Except(listOfInts).ToList(); // Adds the different numbers to a list.
                List<int> sameNumbers = listsToCompare.Intersect(listOfInts).ToList(); //Adds the same numbers to a list.
                                          
                for (int j = 0; j < differentNumbers.Count; j++)
                {
                    listOfInts.Add(differentNumbers[j]);
                }
                for (int y = 0; y < sameNumbers.Count; y++)
                {
                    listOfInts.Remove(sameNumbers[y]);

                    if (listOfInts.Contains(sameNumbers[y]))
                    {
                        y--;
                    }
                }
                
            }
            listOfInts.Sort();

            Console.WriteLine(string.Join(" ", listOfInts));
        }
    }
}
