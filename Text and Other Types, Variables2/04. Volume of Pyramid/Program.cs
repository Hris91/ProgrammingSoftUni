using System;


namespace _04.Volume_of_Pyramid
{
    class Program
    {
       public static void Main(string[] args)
        {
            
            Console.Write("Length: ");
           double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
           double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
           double height = double.Parse(Console.ReadLine());
            double pyramidHeight = (lenght * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidHeight);

        }
    }
}
