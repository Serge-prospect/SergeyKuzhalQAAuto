using System;

namespace BooksInfo
{
    class Program
    {        
        static void Main(string[] args)
        {
            Book[] library = new Book[5];

            // Set known book data: title, page qty
            library[0] = new Book("The Adventures of Tom Sawyer");          // Unknown page qty
            library[1] = new Book(273);                                     // Unknown title
            library[2] = new Book();                                        // Unknown whole book data
            library[3] = new Book("The Lord of the Rings. Part 2", 202);
            library[4] = new Book("The Lord of the Rings. Part 3", 203);

            foreach (Book book in library)
            {
                book.DisplayBookInfo();
            }
        }
    }
}
