using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_Part3_HW3.Class
{
    //  Create concrate class BookFactory
    public class BookFactory : Factory
    {
        private string title;
        private string author;
        private int pages;

        public BookFactory(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public override IProduct CreateProduct()
        {
            return new Book(title, author, pages);
        }
    }
}
