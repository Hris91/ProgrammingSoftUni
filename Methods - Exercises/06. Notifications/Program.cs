using System;


namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                      
            for (int i = 1; i <= n; i++)
            {
                string result = Console.ReadLine();

                if (result == "success" )
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    string success = ShowSucess(operation, message);
                    Console.WriteLine(success);
                }

                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    string error = ShowError(operation, code);
                    Console.WriteLine(error);

                }
                else
                {
                    continue;
                }

            }

        }
        static string ShowSucess(string operation , string message)
        {

            string output = $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
            return output;
                              
        }

        static string ShowError (string operation , int code)
        {
            string reason = string.Empty;

            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }

            else
            {
                reason = "Internal System Failure";
            }

            string output = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.";
            return output;
        }
    }
}
