using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> notes = new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
            List<double> frequencies = new List<double>()
            { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            List<string> resultNotes = new List<string>();

            double naturalsSum = 0;
            double sharpsSum = 0;

            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                int index = frequencies.IndexOf(input[i]);
                string currentNote = notes[index];
                int numberOfChars = currentNote.Length;
                resultNotes.Add(currentNote);

                if (numberOfChars > 1)
                {
                    sharps.Add(currentNote);
                    sharpsSum += input[i];
                }
                else
                {
                    naturals.Add(currentNote);
                    naturalsSum += input[i];
                }  
                                                    
            }
            
            Console.WriteLine($"Notes: {string.Join(" ", resultNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            if (naturalsSum == 0)
            {
                Console.WriteLine($"Naturals sum: 0");
            }
            else
            {
                Console.WriteLine($"Naturals sum: {naturalsSum:f2}");
            }
            if (sharpsSum == 0)
            {
                Console.WriteLine($"Sharps sum: 0");
            }
            else
            {
                Console.WriteLine($"Sharps sum: {sharpsSum:f2}");
            }
           
        }
    }
}
