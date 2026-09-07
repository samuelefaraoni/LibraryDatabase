using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public class AudioRecording : Media
    {
        public string Format { get; init; }
        public string CatalogCode { get; init; }

        public AudioRecording(string name, string[] author, string[] genre, string[] language, string publicationDate, string publisher, string format, string catalogCode) : base(name, author, genre, language, publicationDate, publisher)
        {
            Format = format;
            CatalogCode = catalogCode;
        }

        public override string ReturnInfo()
        {
            return ($"Name: {Name}\nAuthor: {Author}\nGenre: {Genre}\nLanguage: {Language}\nPublication Date: {PublicationDate}\nPublisher: {Publisher}\nFormat: {Format}\nCatalog Code: {CatalogCode}");
        }
    }
}
