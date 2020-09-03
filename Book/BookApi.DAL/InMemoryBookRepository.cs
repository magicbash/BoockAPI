namespace BookApi.DAL
{
    public class InMemoryBookRepository : IBookRepository
    {
        private readonly IBookStorage _bookStorage;

        public InMemoryBookRepository(IBookStorage bookStorage)
        {
            _bookStorage = bookStorage;
        }
        
    }
}