using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public record Book : Media
    {
        public string ISBN { get; init; }

        public Book(string title, string author, string genre, string language, string publicationDate, string publisher, string isbn) : base(title, author, genre, language, publicationDate, publisher)
        {
            ISBN = isbn;
        }

        public override string GetInfo()
        {
            return ($"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}\nLanguage: {Language}\nPublication Date: {PublicationDate}\nPublisher: {Publisher}\nISBN: {ISBN}");
        }

        
    }
}
