using LibraryDatabase.Application.Dto;
using LibraryDatabase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Mappers
{
    public static class BookMapper
    {
        public static BookDto ToDto(Book book)
        {
            return new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Language = book.Language,
                PublicationDate = book.PublicationDate,
                Publisher = book.Publisher,
                ISBN = book.ISBN
            };
        }

        public static Book ToDomain(BookDto dto)
        {
            return new Book(
                dto.Title,
                dto.Author,
                dto.Genre,
                dto.Language,
                dto.PublicationDate,
                dto.Publisher,
                dto.ISBN);
        }
    }
}
