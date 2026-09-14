using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
   public abstract record Media
   {
        public string Title { get; init; }
        public string Author { get; init; }
        public string Genre { get; init; }

        public string Language { get; init; }
        public string PublicationDate { get; init; }
        public string Publisher { get; init; }

        public Media(string title, string author, string genre, string language, string publicationDate, string publisher)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Language = language; 
            PublicationDate = publicationDate;
            Publisher = publisher;
        }
        public abstract string GetInfo();
    }
}
