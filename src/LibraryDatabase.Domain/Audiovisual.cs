using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public record Audiovisual : Media
    {
        public Audiovisual(string title, string author, string genre, string language, string publicationDate, string publisher) : base(title, author, genre, language, publicationDate, publisher) {}

        public override string GetInfo()
        {
            return ($"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}\nLanguage: {Language}\nPublication Date: {PublicationDate}\nPublisher: {Publisher}");
        }
    }
}
