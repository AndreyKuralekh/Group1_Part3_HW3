using Group1_Part3_HW3.Class;

namespace Group1_Part3_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate fabrics 
            var bookFactory = new BookFactory("The Lord of the Rings", "J.R.R. Tolkien", 1137);
            var gameFactory = new GameFactory("The Witcher 3", "RPG", 4.8);

            //Create products
            var book = bookFactory.CreateProduct();

            var game = gameFactory.CreateProduct();

            book.PrintAll();
            game.PrintAll();
        }
    }
}