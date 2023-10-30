using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Questions.csv";
            int MaxAttempts = 3;
            Game game = new Game(path, MaxAttempts);
            game.PlayGame();
        }
    }
}