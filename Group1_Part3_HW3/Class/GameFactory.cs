using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_Part3_HW3.Class
{
    // Create concrate class GameFactory
    public class GameFactory : Factory
    {
        private string name;
        private string genre;
        private double rating;

        public GameFactory(string name, string genre, double rating)
        {
            this.name = name;
            this.genre = genre;
            this.rating = rating;
        }

        public override IProduct CreateProduct()
        {
            return new Game(name, genre, rating);
        }
    }
}
