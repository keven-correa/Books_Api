using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class PublisherViewModel
    {
        public string Name { get; set; }
    }

    public class PublisherWithBooksAndAuthorsViewModel
    {
        public string Name { get; set; }

        public List<BookAuthorViewModel> BookAuthors { get; set; }
    }

    public class BookAuthorViewModel
    {
        public string BookName { get; set; }

        public List<string> BookeAuthors { get; set; }
    }

}
