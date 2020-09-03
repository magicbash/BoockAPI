using BookApi.Data.Entities;

namespace BookApi.DAL
{
    public interface IRandomBookCreator
    {
        Book CreateBook();
    }
}