using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAge = new Dictionary<string,int>();
            var nameSalary = new Dictionary<string,double>();
            var namePosition = new Dictionary<string,string>();

            string line = Console.ReadLine();

            while (line != "filter base")
            {
                string[] input = line.Split(' ').ToArray();

                string name = input[0];
                string secondInput = input[2];

                double salary = 0;
                int age = 0;
                string position = secondInput;

                if (int.TryParse(secondInput, out age))
                {
                    nameAge[name] = age;
                }
                else if (double.TryParse(secondInput, out salary))
                {
                    nameSalary[name] = salary;
                }
                else
                {
                    namePosition[name] = position;
                }

                line = Console.ReadLine();
            }

            string outPut = Console.ReadLine();

            if (outPut == "Age")
            {
                foreach (KeyValuePair<string,int> ktp in nameAge)
                {
                    Console.WriteLine($"Name: {ktp.Key}");
                    Console.WriteLine($"Age: {ktp.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (outPut == "Salary")
            {
                foreach (KeyValuePair<string,double> ktp in nameSalary)
                {
                    Console.WriteLine($"Name: {ktp.Key}");
                    Console.WriteLine($"Salary: {ktp.Value:f2}");
                    Console.WriteLine("====================");
                }
            }
            else if (outPut == "Position")
            {
                foreach (KeyValuePair<string, string> ktp in namePosition)
                {
                    Console.WriteLine($"Name: {ktp.Key}");
                    Console.WriteLine($"Position: {ktp.Value}");
                    Console.WriteLine("====================");
                }
            }          
        }
    }
}
