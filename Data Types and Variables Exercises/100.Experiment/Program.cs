using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100.Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber =ulong.Parse(Console.ReadLine());

            ulong greaterNumber = 0;
            ulong smallerNumber = 0;


            if (firstNumber >= secondNumber)
            {
                greaterNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else if (secondNumber > firstNumber)
            {
                greaterNumber = secondNumber;
                smallerNumber = firstNumber;
            }

            string typeGreater = NumericTypeGreater(greaterNumber);
            string typeSmaller = NumericTypeSmaller(smallerNumber);

            double overFlowed = 0.0;

            if (typeSmaller == "byte")
            {
                overFlowed =(double) greaterNumber / byte.MaxValue;
            }
            else if (typeSmaller == "ushort")
            {
                overFlowed = (double)greaterNumber / ushort.MaxValue;
            }
            else if (typeSmaller == "uint")
            {
                overFlowed = (double)greaterNumber / uint.MaxValue;
            }
            else if (typeSmaller == "ulong")
            {
                overFlowed = (double)greaterNumber / ulong.MaxValue;
            }
          

            Console.WriteLine($"bigger type: {typeGreater}");
            Console.WriteLine($"smaller type: {typeSmaller}");
            Console.WriteLine($"{greaterNumber} can overflow {typeSmaller} {Math.Round(overFlowed)} times");



        }
      // Determines what type is the greater number.
        static string NumericTypeGreater( ulong greaterNumber)
        {
            string type = string.Empty;
            if (greaterNumber >= byte.MinValue && greaterNumber <= byte.MaxValue)
            {
                type = "byte";
            }
            else if( greaterNumber >=ushort.MinValue  && greaterNumber <= ushort.MaxValue)
            {
                type = "ushort";
            }
            else if (greaterNumber >= uint.MinValue  && greaterNumber <= uint.MaxValue)
            {
                type = "uint";
            }
            else if (greaterNumber >=ulong.MinValue && greaterNumber <= ulong.MaxValue)
            {
                type = "ulong";
            }
            return type;
        }
        // Determines what type is the smaller number.
        static string NumericTypeSmaller( ulong smallerNumber)
        {
            string type = string.Empty;
            if (smallerNumber >= byte.MinValue  && smallerNumber <= byte.MaxValue)
            {
                type = "byte";
            }
            else if (smallerNumber >= ushort.MinValue && smallerNumber <= ushort.MaxValue)
            {
                type = "ushort";
            }
            else if (smallerNumber >= uint.MinValue && smallerNumber <= uint.MaxValue)
            {
                type = "uint";
            }
            else if (smallerNumber >= ulong.MinValue && smallerNumber <= ulong.MaxValue)
            {
                type = "ulong";
            }
            return type;
        }
       

    }
}
