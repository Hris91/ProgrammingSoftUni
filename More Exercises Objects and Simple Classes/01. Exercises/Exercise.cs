using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeConstestLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercise AddExercise(string line)
        {
            string[] tokens = line
                .Split(new[] {' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var currentExercise = new Exercise()
                {
                Topic = tokens[0],
                CourseName = tokens[1],
                JudgeConstestLink = tokens[2],
                Problems = new List<string>()
                };
            for (int i = 3; i < tokens.Length; i++)
            {
                currentExercise.Problems.Add(tokens[i]);
            }

            return currentExercise;
        }
    }
}
