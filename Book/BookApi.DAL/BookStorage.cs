using System.Collections;
using System.Collections.Generic;
using BookApi.Data.Entities;

namespace BookApi.DAL
{
    public class BookStorage : IBookStorage
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly int _initNumber = 5;
        
        public BookStorage(IRandomBookCreator bookCreator)
        {
            for (var i = 0; i < _initNumber; i++)
            {
                _books.Add(bookCreator.CreateBook());
            }
        }

        public IEnumerable<Book> Books()
        {
            return _books;
        }
    }
}