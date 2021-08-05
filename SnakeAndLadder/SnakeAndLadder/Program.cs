using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and ladder game");
            int player = 1;
            int position;
            int position1 = 0;
            while (position1 < 100)
            {
                Random rand = new Random();
                int diceNum = rand.Next(1, 7);
                Console.WriteLine("The random dice number is :" + diceNum);
                position = rand.Next(0, 3);
                Console.WriteLine("The position of the player" + position);
                if (position == 1)
                {
                    if (position1 <= 100)
                    {
                        position1 = position1 + diceNum;
                    }
                }
                else if (position == 2)
                {
                    position1 = position1 - diceNum;
                    if (position1 < 0)
                    {
                        position1 = 0;
                    }
                }
                else
                {
                    position1 = position1 + 0;
                }
            Console.WriteLine("The player wins with the position" + position1);
            }

        }
    }
}
