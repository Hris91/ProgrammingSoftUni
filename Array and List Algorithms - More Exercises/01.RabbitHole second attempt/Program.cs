﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole_second_attempt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            int currentIndex = 0;
           
            bool lastBomb = false;

            while (energy > 0)
            {
                string[] commandParams = commands[currentIndex].Split('|');
                string currentCommand = commandParams[0];             
                lastBomb = false;

                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");                   
                    break;
                }

                int value = int.Parse(commandParams[1]);
               
                switch (currentCommand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % commands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % commands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        commands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;                       
                        break;
                    
                }
                if (commands[commands.Count-1] != "RabbitHole")
                {
                    commands.RemoveAt(commands.Count - 1);
                }
               commands.Add("Bomb|" + energy);
            }
            if (energy <=0 && lastBomb)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (energy <= 0 && !lastBomb)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }                  
        }
    }
}
