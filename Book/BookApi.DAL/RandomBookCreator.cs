using BookApi.Data.Entities;
using System;


namespace BookApi.DAL
{
    public class RandomBookCreator : IRandomBookCreator
    {
        private static int _Id;

        public Book CreateBook()
        {

            //todo 
            
            Id = RandomBookCreator._Id++;


            String[] RandomFirstNameArray = new String[] {"John", "Andrew", "Jack", "Captain", "Dober"};
            String[] RandomSecondNameArray = new String[] {"Hoy", "Boyy", "Eren", "Crown", "Corman"};

            
            Random _rnd = new Random();

            int RandomFirstName = _rnd.Next(0, RandomFirstNameArray.Length);
            int RandomSecondName = _rnd.Next(0, RandomSecondNameArray.Length); //generate random authorname


            String[] RandomBookNameArray = new String[] { "Anna Karenina", "Madame Bovary", "War and Peace", "The Great Gatsby", "Lolita", "Middlemarch", "The Adventures of Huckleberry Finn" };
            int RandomBookName = _rnd.Next(0, RandomBookNameArray.Length); //generate random bookname


            String[] RandomPublisherArray = new String[] { "McGraw-Hill Education", "Scholastic", "Springer Nature", "Grupo Planeta", "Hachette Livre", "Wolters Kluwer", "Bertelsmann" };
            int RandomPublisherName = _rnd.Next(0, RandomPublisherArray.Length); //generate random publishername

            int[] RandomAgeLimitArray = new int[] { 0, 3, 12, 14, 16, 18, 21 };
            int RandomAgeLimit = _rnd.Next(0, RandomAgeLimitArray.Length);

        }
    }
}