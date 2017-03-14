using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();
            List<string> words = new List<string>();
            List<int> accurances = new List<int>();

            int counter = 0;
          

            for (int i = 0; i < inputStrings.Length; i++)
            {               
                string currentElement = inputStrings[i];

                if (! words.Contains(currentElement))
                {
                    words.Add(currentElement);
                    accurances.Add(1);
                }
                else if (words.Contains(currentElement))
                {
                    int index = words.IndexOf(currentElement);
                    accurances[index]++;
                }                          
            }

            for (int i = 0; i < words.Count-1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (accurances[j] > accurances[j-1] )
                    {
                        int tempForAccurances = accurances[j];
                        accurances[j] = accurances[j-1];
                        accurances[j - 1] = tempForAccurances;

                        string tempForWords = words[j];
                        words[j] = words[j - 1];
                        words[j - 1] = tempForWords;
                    }
                    j--;
                }
            }

            for (int i = 0; i < accurances.Count; i++)
            {
                double sum = accurances.Sum();
                double currentAccurance = accurances[i];
                double percentOfAccurances = (currentAccurance / sum) * 100;
                Console.WriteLine($"{words[i]} -> {accurances[i]} times ({percentOfAccurances:f2}%)");
            }

        }
    }
}
