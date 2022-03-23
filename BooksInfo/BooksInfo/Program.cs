using System;

namespace BooksInfo
{
    class Program
    {        
        static void Main(string[] args)
        {
            Book[] library = new Book[5];

            // Generate unique book id
            for (int index = 0; index < library.Length; index++)
            {
                string id = (index + 1).ToString();
                library[index] = new Book(id);
            }

            // Set known book data: title, page qty
            library[0].Title = "The Adventures of Tom Sawyer";
            //library[0].pages = 95;                            // Unknown page qty

            //library[1].title = "Treasure Island";             // Unknown title
            library[1].Pages = 273;

            library[2].Title = "The Lord of the Rings. Part 1";
            library[2].Pages = 201;

            library[3].Title = "The Lord of the Rings. Part 2";
            library[3].Pages = 202;

            library[4].Title = "The Lord of the Rings. Part 3";
            library[4].Pages = 203;

            foreach (Book book in library)
            {
                book.DisplayBookInfo();
            }
        }
    }
}
