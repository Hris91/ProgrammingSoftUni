using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsList = new List<Student>();

            string text = Console.ReadLine();

            List<string> lines = text.Split(new[] {'{'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            lines.RemoveAt(0);

            
            foreach (var line in lines)
            {
                Student currentStudent = new Student();
                currentStudent.Grades = new List<int>();

                int indexfirstForName = line.IndexOf("\"");
                int indexLastforName = line.LastIndexOf("\"");
                int lenghtForName = Math.Abs(indexfirstForName - indexLastforName);
                string currentName = line.Substring(indexfirstForName + 1 , lenghtForName - 1);
                currentStudent.Name = currentName;

                int indexFirstForAge = line.IndexOf("age:") + 4;
                int indexLastForAge = line.IndexOf(",grades");
                int lenghtForAge = Math.Abs(indexFirstForAge - indexLastForAge);               
                int currentAge = int.Parse(line.Substring(indexFirstForAge, lenghtForAge));
                currentStudent.Age = currentAge;

                int indexFirstForGrades = line.IndexOf("[")+1;
                int indexLastForGrades = line.LastIndexOf("]");
                int lenghtForGrades = Math.Abs(indexFirstForGrades - indexLastForGrades);
                string currentText = line.Substring(indexFirstForGrades, lenghtForGrades);
                string[] gradesAsString =
                    currentText.Split(new[] {']', ' ', '}', ','}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var gradeAsString in gradesAsString)
                {
                    int resultGrade = 0;
                    bool isItGrade = int.TryParse(gradeAsString, out resultGrade);
                    currentStudent.Grades.Add(resultGrade);
                }

                studentsList.Add(currentStudent);                                      
            }

            foreach (var student in studentsList)
            {
                if (student.Grades.Count == 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }               
            }
        }
    }
}
