using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_Part3_HW3.Class
{
    // Define concrate class Book
    public class Book : IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        // Define constractor Book
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void PrintAll()
        {
            Console.WriteLine($"Book: {Title} by {Author}, {Pages} pages");
        }
    }
}
