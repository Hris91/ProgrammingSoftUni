using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var forumTopics = new Dictionary<string,HashSet<string>>();
            string line = Console.ReadLine();

            while (line != "filter")
            {
                string[] tokens = line.Split(new[] {' ', '-', '>', ','},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string topic = tokens[0];

                AddToDictionarie(topic, tokens, forumTopics);

                line = Console.ReadLine();
            }
           
            string[] contaimentTags = Console.ReadLine().Split(new[] {' ', ','},StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            foreach (var ktp in forumTopics)
            {
                bool containsTag = true;
                var topicKey = ktp.Key;
                var hashTags = ktp.Value;

                for (int i = 0; i < contaimentTags.Length; i++)
                {
                    if (!hashTags.Contains(contaimentTags[i]))
                    {
                        containsTag = false;
                        break;
                    }
                }
                if (containsTag)
                {
                    Console.WriteLine($"{topicKey} | {string.Join(", ",hashTags.Select(p => "#"+p))}");
                }
            }
            
        }

        private static void AddToDictionarie(string topic, string[] tokens, Dictionary<string, HashSet<string>> forumTopics)
        {
            if (!forumTopics.ContainsKey(topic))
            {
                forumTopics[topic] = new HashSet<string>();
            }
            for (int i = 1; i < tokens.Length; i++)
            {
                forumTopics[topic].Add(tokens[i]);
            }
        }
    }
}
