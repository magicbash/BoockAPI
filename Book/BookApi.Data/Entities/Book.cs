namespace BookApi.Data.Entities

{
    //todo add other book properties +
    public class Book
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public int AgeLimit { get; set; }

        public string Publisher { get; set; }

        public int Id { get; set; }
    }
}