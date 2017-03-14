using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var logins = new Dictionary<string,string>();

            string input = Console.ReadLine();

            while (input != "login")
            {
                string[] AddUserAndPass = input.Split(' ').ToArray();
                string user = AddUserAndPass[0];
                string password = AddUserAndPass[2];

                logins[user] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            int unsuccessfulLoginAttempts = 0;
            while (input != "end")
            {

                string[] AddUserAndPass = input.Split(' ').ToArray();
                string user = AddUserAndPass[0];
                string password = AddUserAndPass[2];

                if (!logins.ContainsKey(user) || logins[user] != password)
                {
                    Console.WriteLine($"{user}: login failed");
                    unsuccessfulLoginAttempts++;
                }
                else
                {
                    Console.WriteLine($"{user}: logged in successfully");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLoginAttempts}");
        }
    }
}
