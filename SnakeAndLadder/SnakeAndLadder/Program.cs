using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and ladder game");
         
            int position;
<<<<<<< HEAD
            int player = 0;
            int[] playerPosition = new int[2] { 0, 0 };
            int diceRollCount = 0;
            while (playerPosition[player] < 100)
=======
            int position1 = 0;
            int diceRollCount = 0;
            while (position1 < 100)
>>>>>>> 1ec3711077e3705096d0e6ab7c1ea2e813b07fbd
            {
                Random rand = new Random();
                int diceNum = rand.Next(1, 7);
                Console.WriteLine("The random dice number is :" + diceNum);
                diceRollCount++;
                position = rand.Next(0, 3);
                Console.WriteLine("The position of the player" + position);
                if (position == 1)
                {
<<<<<<< HEAD
                    if (playerPosition[player] + diceNum <= 100)
=======
                    if ((position1 + diceNum) <= 100)
>>>>>>> 1ec3711077e3705096d0e6ab7c1ea2e813b07fbd
                    {
                        playerPosition[player] = playerPosition[player] + diceNum;
                    }
                    Console.WriteLine(" player " + player + "position: " + playerPosition[player]);
                }
                else if (position == 2)
                {
                    playerPosition[player] = playerPosition[player] - diceNum;
                    if (playerPosition[player] < 0)
                    {
                        playerPosition[player] = 0;
                    }

                    Console.WriteLine(" player " + player + "position: " + playerPosition[player]);
                }
                else
                {
                    Console.WriteLine(" player " + player + "position: " + playerPosition[player]);
                }
<<<<<<< HEAD
                 if (position == 0 || position == 2)
                {
                    if (player == 0)
                    {
                        player = 1;
                    }
                    else
                    {
                        player = 0;
                    }
                }
                }
            Console.WriteLine("The winner of snake and ladder is player" + player);
                    Console.WriteLine("The number of times dice roll is :" + diceRollCount);
               /// Console.WriteLine("The winning player is :" + winningPlayer);
              
=======
            Console.WriteLine("The number of times dice rolled is :" + diceRollCount);
>>>>>>> 1ec3711077e3705096d0e6ab7c1ea2e813b07fbd
            }

        }
    }

