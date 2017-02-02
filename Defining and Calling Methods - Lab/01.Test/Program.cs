using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Test
{
    class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintreceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintReceiptFooter()
        {
            string unicode = "\u00A9";
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{unicode} SoftUni");
        }
        static void PrinReceipt()
        {
            PrintReceiptHeader();
            PrintreceiptBody();
            PrintReceiptFooter();
        }
        static void Main(string[] args)
        {
            PrinReceipt();
        }
    }
}
