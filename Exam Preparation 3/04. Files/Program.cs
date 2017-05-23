using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Root> roots = new Dictionary<string, Root>();

          
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split('\\');

                string currentRootName = tokens[0];
                string[] file = tokens[tokens.Length - 1].Split(new[] {'.', ';'}, StringSplitOptions.RemoveEmptyEntries);
                string fileName = file[0];
                string fileExtension = file[1];
                long fileSize = long.Parse(file[file.Length - 1]);

                Root currentRoot = new Root();
                currentRoot.FileName = fileName;
                currentRoot.Extension = fileExtension;
                currentRoot.FileSize = fileSize;
                currentRoot.RootName = currentRootName;
              
                roots[fileName] = currentRoot;

            }
            string[] quaery = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
            string extensionToSearch = quaery[0];
            string rootToSearch = quaery[2];

            bool isThereAmatch = false;



            roots = roots
                .OrderByDescending(y => y.Value.FileSize)
                .ThenBy(y => y.Value.FileName)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var root in roots)
            {
                if (root.Value.RootName == rootToSearch)
                {
                    if (root.Value.Extension == extensionToSearch)
                    {
                        Console.WriteLine($"{root.Value.FileName}.{root.Value.Extension} - {root.Value.FileSize} KB");
                        isThereAmatch = true;
                    }
                }
            }
            if (!isThereAmatch)
            {
                Console.WriteLine("No");
            }


        }
    }
}
