using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Exercise currentExercise = new Exercise();
            var topics = new Dictionary<string, Exercise>();

            while (line != "go go go")
            {               
                currentExercise = currentExercise.AddExercise(line);
                if (!topics.ContainsKey(currentExercise.Topic))
                {
                    topics[currentExercise.Topic] = new Exercise();
                }

                topics[currentExercise.Topic] = currentExercise;

                line = Console.ReadLine();
            }

            foreach (var topic in topics)
            {
                Console.WriteLine($"Exercises: {topic.Key}");
                Console.WriteLine($"Problems for exercises and homework for the \"{topic.Value.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {topic.Value.JudgeConstestLink}");
                int counter = 1;
                foreach (var problem in topic.Value.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }                     
        }
    }
}
