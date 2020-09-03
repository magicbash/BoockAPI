using System.Collections.Generic;
using BookApi.Data.Entities;

namespace BookApi.DAL
{
    public interface IBookStorage
    {
        IEnumerable<Book> Books();
    }
}