using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and ladder game");
           int player = 1;
            int position = 0;
            Random rand = new Random();
            int diceNum = rand.Next(1, 7);
            Console.WriteLine("The random dice number is :" + diceNum);
            position = rand.Next(0, 3);
            Console.WriteLine("The position of the player" + position);
            if (position == 1)
            {
                Console.WriteLine("Ladder moves ahead by the position received in the die");
            }
            else if (position == 2)
            {
                Console.WriteLine("Snake moves behind by the position received in the die");
            }
            else
            {
                Console.WriteLine("The player stays in same position");
            }
        }
    }
}
