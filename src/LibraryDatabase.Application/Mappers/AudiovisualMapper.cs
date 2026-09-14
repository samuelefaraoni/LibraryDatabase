using LibraryDatabase.Application.Dto;
using LibraryDatabase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Mappers
{
    public static class AudiovisualMapper
    {
        public static AudiovisualDto ToDto(Audiovisual audiovisual)
        {
            return new AudiovisualDto
            {
                Title = audiovisual.Title,
                Author = audiovisual.Author,
                Genre = audiovisual.Genre,
                Language = audiovisual.Language,
                PublicationDate = audiovisual.PublicationDate,
                Publisher = audiovisual.Publisher
            };
        }

        public static Audiovisual ToDomain(AudiovisualDto dto)
        {
            return new Audiovisual(
                dto.Title,
                dto.Author,
                dto.Genre,
                dto.Language,
                dto.PublicationDate,
                dto.Publisher);
        }
    }
}
