using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Animals
    {
        static void Main()
        {
            var dogsCollection = new Dictionary<string, Dog>();
            var catsCollection = new Dictionary<string, Cat>();
            var snakesCollection = new Dictionary<string, Snake>();

            string line = Console.ReadLine();

            while (line != "I'm your Huckleberry")
            {
                string[] tokens = line.Split(' ').ToArray();

                if (tokens[0] == "Dog" || tokens[0] == "Cat" || tokens[0] == "Snake")
                {
                    if (tokens[0] == "Dog")
                    {
                        Dog currentDog = new Dog();
                        currentDog = currentDog.CreateADog(line);

                        if (!dogsCollection.ContainsKey(tokens[1]) && !catsCollection.ContainsKey(tokens[1])
                            && !snakesCollection.ContainsKey(tokens[1]))
                        {
                            //dogsCollection[tokens[1]] = new Dog();
                            dogsCollection[tokens[1]] = currentDog;
                        }
                    }
                    else if (tokens[0] == "Cat")
                    {
                        Cat currentCat = new Cat();
                        currentCat = currentCat.CreateACat(line);
                        if (!catsCollection.ContainsKey(tokens[1]) && !dogsCollection.ContainsKey(tokens[1])
                            && !snakesCollection.ContainsKey(tokens[1]))
                        {
                            //catsCollection[tokens[1]] = new Cat();
                            catsCollection[tokens[1]] = currentCat;
                        }

                    }
                    else if (tokens[0] == "Snake")
                    {
                        Snake currentSnake = new Snake();
                        currentSnake = currentSnake.CreateASnake(line);

                        if (!snakesCollection.ContainsKey(tokens[1]) && !catsCollection.ContainsKey(tokens[1])
                            && !dogsCollection.ContainsKey(tokens[1]))
                        {
                            //snakesCollection[tokens[1]] = new Snake();
                            snakesCollection[tokens[1]] = currentSnake;
                        }
                    }
                }
                else if(tokens[0] == "talk")
                {
                    if (dogsCollection.ContainsKey(tokens[1]))
                    {
                        dogsCollection[tokens[1]].ProduceSound();
                    }
                    else if (catsCollection.ContainsKey(tokens[1]))
                    {
                        catsCollection[tokens[1]].ProduceSound();
                    }
                    else if (snakesCollection.ContainsKey(tokens[1]))
                    {
                        snakesCollection[tokens[1]].ProduceSound();
                    }
                }
                line = Console.ReadLine();
            }
            foreach (var dog in dogsCollection)
            {
                Console.WriteLine($"Dog: {dog.Key}, Age: {dog.Value.Age}, Number Of Legs: {dog.Value.NumberOfLegs}");
            }
            foreach (var cat in catsCollection)
            {
                Console.WriteLine($"Cat: {cat.Key}, Age: {cat.Value.Age}, IQ: {cat.Value.IntelligenceQuotient}");
            }
            foreach (var snake in snakesCollection)
            {
                Console.WriteLine($"Snake: {snake.Key}, Age: {snake.Value.Age}, Cruelty: {snake.Value.CrueltyCoefficient}");
            }
        }
    }
}
