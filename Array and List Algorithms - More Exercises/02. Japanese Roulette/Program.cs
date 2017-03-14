using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine().Split(' ').ToArray();
            bool playerIsDead = false;
            bool hasFirstPlayerFired = false;

            int bulletPosition = 0;

         

            for (int i = 0; i < players.Length; i++)
            {
                string currentPlayer = players[i];
                int currentPower = ReturnCurrentPower(currentPlayer);
                string currenCommand = ReturnCurrentCommand(currentPlayer);
                int spinedCylinderPosition = 0;

                spinedCylinderPosition = SpinTheCylinder(currentPower, currenCommand, cylinder);

                for (int j = 0; j < cylinder.Length; j++)
                {
                    if (j == spinedCylinderPosition)
                    {
                        cylinder[j] = 1;
                    }
                    else
                    {
                        cylinder[j] = 0;
                    }
                }


                if (spinedCylinderPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    playerIsDead = true;
                    break;
                }

                int cylinderPositionAfeterFire = AfterShooting(currentPower, currenCommand, cylinder , spinedCylinderPosition);

                for (int j = 0; j < cylinder.Length; j++)
                {
                    if (j == cylinderPositionAfeterFire)
                    {
                        cylinder[j] = 1;
                    }
                    else
                    {
                        cylinder[j] = 0;
                    }
                }


            }
            if (!playerIsDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
           
        }

        

        private static string ReturnCurrentCommand(string currentPlayer)
        {
            string[] stringArray = currentPlayer.Split(',');
            return stringArray[1];
        }

        static int ReturnCurrentPower(string currentPlayer)
        {
            string[] stringArray = currentPlayer.Split(',');
            int currentPower = int.Parse(stringArray[0]);
            return currentPower;
        }

        static int SpinTheCylinder(int currentPower, string currentCommand,int[] cylinder)
        {
            int currentPosition = 0;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1 )
                {
                    currentPosition = i;
                    break;
                }
            }
            if (currentCommand == "Right")
            {
                currentPosition = (currentPosition + currentPower) % cylinder.Length;
            }
            else if (currentCommand == "Left")
            {
                if (currentPosition - currentPower >= 0)
                {
                    currentPosition = currentPosition - currentPower;
                }
                else
                {
                    currentPosition = ((currentPosition - currentPower) % cylinder.Length) + cylinder.Length;
                    //currentPosition = currentPosition + cylinder.Length;
                }
               
            }
            return currentPosition;
        }

        private static int AfterShooting(int currentPower, string currentCommand, int[] cylinder, int spinedCylinderPosition)
        {
            int currentPosition = spinedCylinderPosition;
            currentPosition = (currentPosition + 1) % cylinder.Length;
            return currentPosition;
        }

    }
}
