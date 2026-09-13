using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public class Audiovisual : Media
    {
        public Audiovisual(string name, string[] author, string genre, string language, string publicationDate, string publisher) : base(name, author, genre, language, publicationDate, publisher) {}

        public override string ReturnInfo()
        {
            return ($"Name: {Name}\nAuthor: {Author}\nGenre: {Genre}\nLanguage: {Language}\nPublication Date: {PublicationDate}\nPublisher: {Publisher}");
        }
    }
}
