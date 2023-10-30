using System;
using System.Linq;

namespace HomeWork_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = File.ReadAllLines(@"Top100ChessPlayers.csv")
                          .Skip(1)
                          .Select(ChessPlayer.ParseFideCsv)
                          .Where(player => player.Country == "RUS")
                          .OrderBy(player => player.Birth_Year)
                          .ToList();

            foreach (var player in players)
            {
                Console.WriteLine(player);
            }
            Console.ReadLine();
        }
    }
}