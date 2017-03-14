using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().ToLower().Split(' ').ToArray();

            var wordsDictionarie = new Dictionary<string,int>();

            var resultList = new List<string>();

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (!wordsDictionarie.ContainsKey(stringArray[i]))
                {
                    wordsDictionarie[stringArray[i]] = 0;
                }
                wordsDictionarie[stringArray[i]]++;
            }
            foreach (KeyValuePair<string,int> kvp in wordsDictionarie)
            {
                if (kvp.Value % 2 != 0)
                {
                    resultList.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",resultList));
           
        }
    }
}
