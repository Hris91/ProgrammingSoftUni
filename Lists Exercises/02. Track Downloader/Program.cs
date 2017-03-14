using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();

            string input = string.Empty;
            bool isItInBlackList = false;

            do
            {
                
                input = Console.ReadLine();
                for (int i = 0; i < blackList.Count; i++)
                {
                    isItInBlackList = input.Contains(blackList[i]);
                    if (isItInBlackList == true)
                    {
                        break;
                    }

                }
                if (isItInBlackList == false && input != "end")
                {
                    result.Add(input);
                }
                        

            } while (input != "end");
            result.Sort();


            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }

           

            
        }
    }
}
