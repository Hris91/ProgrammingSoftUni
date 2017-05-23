using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(' ');

                string currentCommand = tokens[0];

                if (currentCommand == "reverse" || currentCommand == "sort")
                {
                    int start = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);
                    

                    if (start < input.Count && start >= 0 && input.Count >= start + count && count >= 0)
                    {
                        if (currentCommand == "reverse")
                        {
                            input.Reverse(start, count);
                        }
                        else if (currentCommand == "sort")
                        {
                            input.Sort(start, count, null);

                        }               
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (currentCommand == "rollLeft" || currentCommand == "rollRight")
                {
                    int count = int.Parse(tokens[1]);
                    int rotations = count % input.Count;

                    if (count >= 0)
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            if (currentCommand == "rollLeft")
                            {
                                string replaced = input[0];
                                input.RemoveAt(0);
                                input.Add(replaced);
                            }
                            else if (currentCommand == "rollRight")
                            {
                                string replaced = input[input.Count - 1];
                                input.RemoveAt(input.Count - 1);
                                input.Insert(0, replaced);
                            }
                        }
                    }
                }
                line = Console.ReadLine();

            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
