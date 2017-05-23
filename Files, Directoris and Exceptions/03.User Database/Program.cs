using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.User_Database
{
    class Program
    {
        private static string dbPath = "users.txt";

        static void Main(string[] args)
        {           
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath);
            }
          
            var users = new Dictionary<string,User>();

            string[] pastInput = File.ReadAllLines("users.txt");

            if (pastInput.Length > 0)
            {
                foreach (var input in pastInput)
                {
                    string[] newInput = input.Split(' ');
                    string currentUserName = newInput[0];
                    string currentPassword = newInput[1];
                    string isHeLogged = newInput[2];

                    users[currentUserName] = new User();
                    users[currentUserName].name = currentUserName;
                    users[currentUserName].password = currentPassword;
                    if (isHeLogged == "True")
                    {
                        users[currentUserName].isLogedIn = true;
                    }
                    else if(isHeLogged == "False")
                    {
                        users[currentUserName].isLogedIn = false;
                    }
                }
            }
            File.WriteAllText("users.txt", string.Empty);

            string lines = Console.ReadLine();

            while (lines != "exit")
            {
                string[] tokens = lines.Split(' ');


                if (tokens[0] == "register")
                {
                    string userName = tokens[1];
                    string passWord = tokens[2];

                    string confirmPassword = tokens[3];

                    if (passWord == confirmPassword && !users.ContainsKey(userName))
                    {
                        User currentUser = new User();
                        currentUser.name = userName;
                        currentUser.password = passWord;
                        users[userName] = currentUser;
                    }
                    else if (users.ContainsKey(userName))
                    {
                        Console.WriteLine("The given username already exists.");
                    }
                    else if (passWord != confirmPassword)
                    {
                        Console.WriteLine("The two passwords must match.");
                    }

                }
                else if (tokens[0] == "login")
                {
                    string userName = tokens[1];
                    string passWord = tokens[2];

                    if (users.ContainsKey(userName) && passWord == users[userName].password)
                    {
                        users[userName].isLogedIn = true;
                    }
                    else if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine("There is no user with the given username.");
                    }
                    else if (passWord != users[userName].password)
                    {
                        Console.WriteLine("The password you eneterd is incorrect");
                    }
                }
                else if (tokens[0] == "logout")
                {
                    if (users.Values.Any(x => x.isLogedIn != true))
                    {
                        Console.WriteLine("There is no currently logged in user.");
                    }
                    else
                    {
                        users[users.Keys.Last()].isLogedIn = false;                      
                    }
                    
                }
                lines = Console.ReadLine();
            }
         
            foreach (var user in users)
            {
                
                File.AppendAllText("users.txt", $"{user.Value.name} {user.Value.password} {user.Value.isLogedIn.ToString()}\r\n");
            }
           
        }
    }
}
