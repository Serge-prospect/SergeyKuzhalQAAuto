using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog
{
    public class Book
    {
        public string ID { get; } = Guid.NewGuid().ToString();
        public string Title { get; }
        public DateTime PubDate { get; }
        public List<Author> Authors { get; }
        public Book(string title, DateTime pubDate, List<Author> authors)
        {
            Title = title;
            PubDate = pubDate;
            Authors = authors;
        }
    }
}
