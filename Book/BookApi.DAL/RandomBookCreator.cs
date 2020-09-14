using BookApi.Data.Entities;
using System;
using System.Collections.Generic;


namespace BookApi.DAL
{
    public class RandomBookCreator : IRandomBookCreator
    {
        private static int _id;
        private static Random _rnd = new Random();

        public Book CreateBook()
        {

            //todo 
            
            var id = _id++;


            var randomFirstNameArray = new[]{"John", "Andrew", "Jack", "Captain", "Dober"};
            var randomSecondNameArray = new[]{"Hoy", "Boyy", "Eren", "Crown", "Corman"};

            
            var randomFirstName = _rnd.Next(0, randomFirstNameArray.Length);
            var randomSecondName = _rnd.Next(0, randomSecondNameArray.Length); //generate random author name


            var randomBookNameArray = new [] { "Anna Karenina", "Madame Bovary", "War and Peace", "The Great Gatsby", "Lolita", "Middlemarch", "The Adventures of Huckleberry Finn" };
            var randomBookName = _rnd.Next(0, randomBookNameArray.Length); //generate random book name


            var randomPublisherArray = new [] { "McGraw-Hill Education", "Scholastic", "Springer Nature", "Grupo Planeta", "Hachette Livre", "Wolters Kluwer", "Bertelsmann" };
            var randomPublisherName = _rnd.Next(0, randomPublisherArray.Length); //generate random publishername

            var randomAgeLimitArray = new [] { 0, 3, 12, 14, 16, 18, 21 };
            var randomAgeLimit = _rnd.Next(0, randomAgeLimitArray.Length);
            
            

            return new Book
            {
                Id = id,
                Name = randomBookNameArray[randomBookName]
            };
        }
    }
}