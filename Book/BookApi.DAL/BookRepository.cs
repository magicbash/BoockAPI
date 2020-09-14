using BookApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookApi.DAL
{
    class BookRepository : IBookRepository
    {

        private IBookStorage _storage;

        BookRepository(IBookStorage storage)
        {
            this._storage = storage;
        }

        public Book CreateBook(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public Book CreateBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book DeleteOneBook(int id)
        {
            throw new Exception();
        }

        public List<Book> GetAllBooks()
        {
            return _storage.Books().ToList();
        }

        public Book GetOneBook(int id)
        {
            return _storage.Books().First(book => book.Id == id);
        }

        public Book UpdateBook(int id, Book book)
        {
            throw new Exception();
        }
    }
}
