using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var result = new List<string>();
            string line = Console.ReadLine();

            while (line != "stringify")
            {
                string[] tokens = line.Split(new[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                string[] nameAndAge = tokens[0].Split(new[] {' ', ':'}, StringSplitOptions.RemoveEmptyEntries);
                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);
                Student currentStudent = new Student();
                currentStudent.Name = name;
                currentStudent.Age = age;
               
                if (tokens.Length > 1)
                {
                    int[] grades =
                   tokens[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
                    currentStudent.Grades = new List<int>();

                    foreach (var grade in grades)
                    {
                        currentStudent.Grades.Add(grade);
                    }
                }
                                       
                students.Add(currentStudent);

                line = Console.ReadLine();
            }
           
            foreach (var student in students)
            {
                if (student.Grades != null)
                {
                    result.Add($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}");
                }
                else
                {
                    result.Add($"{{name:\"{student.Name}\",age:{student.Age},grades:[]}}");
                }
                              
            }
            Console.WriteLine($"[{string.Join(",",result)}]");
        }
    }

}
