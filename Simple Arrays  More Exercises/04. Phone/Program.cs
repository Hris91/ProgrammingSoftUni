using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.Phone
{
    class Program
    {
      

        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
           

            string nameOrNumber = string.Empty;
            string input = string.Empty;
            do
            {
                input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }

                string[] inputsArray = input.Split(' ');
                string secondInput = inputsArray[1];
                bool isItANumber = IsItNumber(secondInput);
                int sumOfDigits = 0;
                int diferenceOfDigits = 0;
                string sendNumberToMethod = string.Empty;


                if (isItANumber)
                {

                    if (inputsArray[0] == "call") Console.WriteLine
                            ($"calling {ReturnCorespondingName(secondInput, names, phoneNumbers)}...");
                    else if (inputsArray[0] == "message") Console.WriteLine
                            ($"sending sms to {ReturnCorespondingName(secondInput, names, phoneNumbers)}...");

                    sendNumberToMethod = secondInput;
                    sumOfDigits = CalculateSumOfNumber(sendNumberToMethod);
                    diferenceOfDigits = Math.Abs(CalculateDifferenceOfNumber(sendNumberToMethod));

                }
                else
                {
                    if (inputsArray[0] == "call") Console.WriteLine
                            ($"calling {ReturnCorespondingNumber(secondInput, names, phoneNumbers)}...");
                    else if (inputsArray[0] == "message")
                        Console.WriteLine($"sending sms to {ReturnCorespondingNumber(secondInput, names, phoneNumbers)}...");

                    sendNumberToMethod = ReturnCorespondingNumber(secondInput, names, phoneNumbers);
                    sumOfDigits = CalculateSumOfNumber(sendNumberToMethod);
                    diferenceOfDigits = Math.Abs(CalculateDifferenceOfNumber(sendNumberToMethod));
                }

                if (inputsArray[0] == "call")
                {

                    if (sumOfDigits % 2 != 0)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        var toTime = TimeSpan.FromSeconds(sumOfDigits).ToString(@"mm\:ss");

                        Console.WriteLine($"call ended. duration: {toTime}");
                    }
                }
                else if (inputsArray[0] == "message")
                {
                    if (diferenceOfDigits % 2 != 0)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }

            } while (input !="done");

        }

       static int CalculateDifferenceOfNumber(string sendNumberToMethod) // calculates the difference
        {
            char[] charArray = sendNumberToMethod.ToCharArray();
            int toInt = 0;
            int sum = 0;
            bool isItNumber;

            for (int i = 0; i < charArray.Length; i++)
            {
                isItNumber = Char.IsDigit(charArray[i]);
                if (isItNumber)
                {
                    toInt = (int)Char.GetNumericValue(charArray[i]);
                }
                sum -= toInt;
            }
            return sum;
        }

        static bool IsItNumber (string secondInput)
        {
            bool isItNumber = secondInput.Any(Char.IsDigit);
            return isItNumber;
        }

        static string ReturnCorespondingName(string secondInput, string[] names, string[] phoneNumbers) // returns the corresponding name to a number.
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (secondInput == phoneNumbers[i])
                {
                    return names[i];
                }
            }
            return "error";
        }

        static string ReturnCorespondingNumber(string secondInput, string[] names, string[] phoneNumbers) // returns the corresponding number to a name.
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (secondInput == names[i])
                {
                    return phoneNumbers[i];
                }
            }
            return "error";
        }

        static int CalculateSumOfNumber(string sendNumberToMethod) // calculates the sum
        {
            char[] charArray = sendNumberToMethod.ToCharArray();        
            int toInt = 0;
            int sum = 0;
            bool isItNumber;

            for (int i = 0; i < charArray.Length; i++)
            {
                isItNumber = Char.IsDigit(charArray[i]);
                if (isItNumber)
                {
                    toInt = (int)Char.GetNumericValue(charArray[i]);
                }
                sum += toInt;
            }
            return sum;
        }
       
    }
}
