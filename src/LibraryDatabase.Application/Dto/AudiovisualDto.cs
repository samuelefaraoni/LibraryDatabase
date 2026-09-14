using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Dto
{
    public record AudiovisualDto
    {
        public string Title { get; init; }
        public string Author { get; init; }
        public string Genre { get; init; }

        public string Language { get; init; }
        public string PublicationDate { get; init; }
        public string Publisher { get; init; }
    }
}
