using LibraryDatabase.Application.Dto;
using LibraryDatabase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Mappers
{
    public static class AudioRecordingMapper
    {
        public static AudioRecordingDto ToDto(AudioRecording audioRecording)
        {
            return new AudioRecordingDto
            {
                Title = audioRecording.Title,
                Author = audioRecording.Author,
                Genre = audioRecording.Genre,
                Language = audioRecording.Language,
                PublicationDate = audioRecording.PublicationDate,
                Publisher = audioRecording.Publisher,
                Format = audioRecording.Format,
                CatalogCode = audioRecording.CatalogCode
            };
        }

        public static AudioRecording ToDomain(AudioRecordingDto dto)
        {
            return new AudioRecording(
                dto.Title,
                dto.Author,
                dto.Genre,
                dto.Language,
                dto.PublicationDate,
                dto.Publisher,
                dto.Format,
                dto.CatalogCode);
        }
    }
}
