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
        }
    }
}
