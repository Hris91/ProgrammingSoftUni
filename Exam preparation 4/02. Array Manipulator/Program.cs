using System;
using System.Linq;


namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray =
                Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        

            while (true)
            {
                string lines = Console.ReadLine();

                if (lines == "end")
                {
                    break;
                }

                string[] tokens = lines
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);

                        if (index > inputArray.Length || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                       inputArray = Exchange(inputArray, tokens);
                        break;
                    case "max":
                        MaxOddOrEven(inputArray, tokens);
                        break;
                    case "min":
                        MinEvenOrOdd(inputArray, tokens);
                        break;
                    case "first":
                        FirstEvenOrOdd(inputArray, tokens);
                        break;
                    case "last":
                        LastEvenOrOdd(inputArray, tokens);
                        break;
                }

            }
            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        private static void LastEvenOrOdd(int[] inputArray, string[] tokens)
        {
            long count = long.Parse(tokens[1]);
            string evenOrOdd = tokens[2];

            if (evenOrOdd == "even")
            {
                int evenElementsCount = inputArray.Count(x => x % 2 == 0);

                if (count > evenElementsCount && count <= inputArray.Length)
                {
                    count = evenElementsCount;
                }

                if (count <= inputArray.Length && evenElementsCount < 0)
                {
                    int[] resultEven = inputArray
                        .Reverse()
                        .Where(x => x % 2 == 0).
                        Take((int)count)
                        .Reverse()
                        .ToArray();

                    Console.WriteLine($"[{string.Join(", ", resultEven)}]");
                }
                else if (count > inputArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                else if (evenElementsCount == 0)
                {
                    Console.WriteLine("[]");
                }


            }
            else if (evenOrOdd == "odd")
            {
                int oddElementsCount = inputArray.Count(x => x % 2 != 0);

                if (count > oddElementsCount && count <= inputArray.Length)
                {
                    count = oddElementsCount;
                }

                if (count <= inputArray.Length && oddElementsCount > 0)
                {
                    int[] resultEven = inputArray
                        .Reverse()
                        .Where(x => x % 2 != 0).
                        Take((int)count)
                        .Reverse()
                        .ToArray();

                    Console.WriteLine($"[{string.Join(", ", resultEven)}]");
                }
                else if (count > inputArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                else if (oddElementsCount == 0)
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void FirstEvenOrOdd(int[] inputArray, string[] tokens)
        {
            long count = long.Parse(tokens[1]);
            string evenOrOdd = tokens[2];

            if (evenOrOdd == "even")
            {
                int evenElementsCount = inputArray.Count(x => x % 2 == 0);

                if (count > evenElementsCount && count <= inputArray.Length)
                {
                    count = evenElementsCount;
                }

                if (count <= inputArray.Length && evenElementsCount > 0)
                {
                    int[] resultEven = inputArray
                        .Where(x => x % 2 == 0).
                        Take((int)count)
                        .ToArray();

                    Console.WriteLine($"[{string.Join(", ",resultEven)}]");
                }
                else if (count > inputArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                else if (evenElementsCount == 0)
                {
                    Console.WriteLine("[]");
                }
                
               
            }
            else if (evenOrOdd == "odd")
            {
                int oddElementsCount = inputArray.Count(x => x % 2 != 0);

                if (count > oddElementsCount && count <= inputArray.Length)
                {
                    count = oddElementsCount;
                }

                if (count <= inputArray.Length && oddElementsCount > 0)
                {
                    int[] resultEven = inputArray
                        .Where(x => x % 2 != 0).
                        Take((int)count)
                        .ToArray();

                    Console.WriteLine($"[{string.Join(", ", resultEven)}]");
                }
                else if (count > inputArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                else if(oddElementsCount == 0)
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void MinEvenOrOdd(int[] inputArray, string[] tokens)
        {
            string oddOrEven = tokens[1];

            
            if (oddOrEven == "even")
            {
                int countEven = inputArray.Where(p => p % 2 == 0).Count();

                if (countEven > 0)
                {
                    int minEven = Array.LastIndexOf(inputArray, inputArray.Reverse().Where(p => p % 2 == 0).Min());
                    Console.WriteLine(minEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
               
            }
            else
            {
                int countOdd = inputArray.Where(p => p % 2 != 0).Count();

                if (countOdd > 0)
                {
                    int minOdd = Array.LastIndexOf(inputArray, inputArray.Reverse().Where(p => p % 2 != 0).Min());
                    Console.WriteLine(minOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
                
            }

        }

        private static void MaxOddOrEven(int[] inputArray, string[] tokens)
        {
            string oddOrEven = tokens[1];


            if (oddOrEven == "even")
            {
                int countEven = inputArray.Where(p => p % 2 == 0).Count();

                if (countEven > 0)
                {
                    int maxEven = Array.LastIndexOf(inputArray, inputArray.Reverse().Where(p => p % 2 == 0).Max());
                    Console.WriteLine(maxEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }
            else
            {
                int countOdd = inputArray.Where(p => p % 2 != 0).Count();

                if (countOdd > 0)
                {
                    int maxOdd = Array.LastIndexOf(inputArray, inputArray.Reverse().Where(p => p % 2 != 0).Max());
                    Console.WriteLine(maxOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }
        }

        private static int[] Exchange(int[] inputArray, string[] tokens)
        {
            int index = int.Parse(tokens[1]);          
            int[] firstPart = inputArray.Skip(index + 1).ToArray();
            int[] secondPart = inputArray.Take(index + 1).ToArray();

            return inputArray = firstPart.Concat(secondPart).ToArray();
            
        }
    }
}
