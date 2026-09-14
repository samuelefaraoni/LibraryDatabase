using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public record AudioRecording : Media
    {
        public string Format { get; init; }
        public string CatalogCode { get; init; }

        public AudioRecording(string title, string author, string genre, string language, string publicationDate, string publisher, string format, string catalogCode) : base(title, author, genre, language, publicationDate, publisher)
        {
            Format = format;
            CatalogCode = catalogCode;
        }

        public override string GetInfo()
        {
            return ($"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}\nLanguage: {Language}\nPublication Date: {PublicationDate}\nPublisher: {Publisher}\nFormat: {Format}\nCatalog Code: {CatalogCode}");
        }
    }
}
