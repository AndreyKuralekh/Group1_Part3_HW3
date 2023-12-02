using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_Part3_HW3.Class
{
    public class Game : Product
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Define constractor Game
        public Game(string name, string genre, double rating)
        {
            Name = name;
            Genre = genre;
            Rating = rating;
        }

        // Method for printing products
        public override void PrintAll()
        {
            Console.WriteLine($"Game: {Name}, {Genre}, {Rating} stars");
        }
    }
}
