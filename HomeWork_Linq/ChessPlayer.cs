using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Linq
{
    public class ChessPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public int Games { get; set; }
        public int Birth_Year { get; set; }

        public override string ToString()
        {
            return $"Full name {FirstName + " "  + LastName}, Rating = {Rating}, from {Country}, born in {Birth_Year}";
        }

        public static ChessPlayer ParseFideCsv(string lile)
        {
            string[] parts = lile.Split(';');
            return new ChessPlayer()
            {
                Id = int.Parse(parts[0]),
                FirstName = parts[1].Split(' ')[0].Trim(),
                LastName = parts[1].Split(' ')[1].Trim(),
                Country = parts[3].Trim(),
                Title = parts[2].Trim(),
                Rating = int.Parse(parts[4]),
                Birth_Year = int.Parse(parts[6])
            };
        }

    }
}
