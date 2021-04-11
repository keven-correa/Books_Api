using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class AuthorsService
    {
        private readonly AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorViewModel book)
        {
            var _author = new Author()
            {
                FullName = book.FullName

            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksViewModel GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksViewModel() //Cuando el Id sea igual al del parametro de entrada renderiza los datos pata mostrarlos
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();

            return _author;
        }

    }
}
