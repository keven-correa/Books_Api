using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class AuthorViewModel
    {
        public string  FullName { get; set; }
    }

    public class AuthorWithBooksViewModel
    {
        public string FullName { get; set; }

        public List<string> BookTitles { get; set; }
    }
}
