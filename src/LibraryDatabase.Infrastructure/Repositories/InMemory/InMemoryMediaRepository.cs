using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Infrastructure.Repositories.InMemory
{
    public class InMemoryMediaRepository : IMediaRepository
    {
        private readonly MediaCollector _mediaDatabase;

        public InMemoryMediaRepository()
        {

            _mediaDatabase = new MediaCollector();
        }

        public Result AddMedia(Media media)
        {
            if (media == null)
                return Result.Failure(Error.NullValue);

            _mediaDatabase.Collector.Add(media);
            return Result.Success();
        }

        public Result RemoveMedia(Media media)
        {
            if (media == null)
                return Result.Failure(Error.NullValue);

            _mediaDatabase.Collector.Remove(media);
            return Result.Success();
        }

        public string GetMediaInfo(Media media)
        {
            if(_mediaDatabase.Collector.Contains(media))
            {
                return media.GetInfo();
            }
            else
            {
                throw new ArgumentException($"Media not found.");
            }
        }

        public bool IsMediaIntoList(Media media)
        {
            return _mediaDatabase.IsMediaIntoList(media);
        }

        public List<Media> FindMediaByTitle(string title)
        {
            return _mediaDatabase.FindMediaByTitle(title);
        }

        public List<Media> FindMediaByAuthor(string author)
        {
            return _mediaDatabase.FindMediaByAuthor(author);
        }

        public List<Media> FindMediaByGenre(string genre)
        {
            return _mediaDatabase.FindMediaByGenre(genre);
        }

        public List<Media> FindMediaByLanguage(string language)
        {
            return _mediaDatabase.FindMediaByLanguage(language);
        }

        public List<Media> FindMediaByPublicationDate(string publicationDate)
        {
            return _mediaDatabase.FindMediaByPublicationDate(publicationDate);
        }

        public List<Media> FindMediaByPublisher(string publisher)
        {
            return _mediaDatabase.FindMediaByPublisher(publisher);
        }

        public Book FindBookByISBN(string isbn)
        {
            return _mediaDatabase.FindBookByISBN(isbn);
        }

        public List<AudioRecording> FindAudioRecordingByFormat(string format)
        {
            return _mediaDatabase.FindAudioRecordingByFormat(format);
        }

        public AudioRecording FindAudioRecordingByCatalogCode(string catalogCode)
        {
            return _mediaDatabase.FindAudioRecordingByCatalogCode(catalogCode);
        }
    }
}
