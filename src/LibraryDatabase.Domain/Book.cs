using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public class Book : Media
    {
        public string ISBN { get; init; }

        public Book(string name, string[] author, string[] genre, string[] language, string publicationDate, string publisher, string isbn) : base(name, author, genre, language, publicationDate, publisher)
        {
            ISBN = isbn;
        }

        public override string ReturnInfo()
        {
            return ($"Name: {Name}\nAuthor: {Author}\nGenre: {Genre}\nLanguage: {Language}\nPublication Date: {PublicationDate}\nPublisher: {Publisher}\nISBN: {ISBN}");
        }
    }
}
