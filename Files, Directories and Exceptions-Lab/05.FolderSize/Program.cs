using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] directorie = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in directorie)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("result.txt", sum.ToString());
        }
    }
}
