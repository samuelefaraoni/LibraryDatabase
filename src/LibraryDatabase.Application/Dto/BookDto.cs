using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Dto
{
    public record BookDto
    {
        public string Name { get; init; }
        public string[] Author { get; init; }
        public string Genre { get; init; }

        public string Language { get; init; }
        public string PublicationDate { get; init; }
        public string Publisher { get; init; }
        public string ISBN { get; init; }
    }
}
