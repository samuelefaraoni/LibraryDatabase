using LibraryDatabase.SharedKernel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibraryDatabase.Domain
{
    public class MediaCollector
    {
        public List<Media> Collector;

        public MediaCollector()
        {
            Collector = new List<Media>();
        }

        public Result AddMedia(Media media)
        {
            Collector.Add(media);
            return Result.Success();
        }

        public Result RemoveMedia(Media media)
        {
            if (Collector.Remove(media) == true)
                return Result.Success();
            else return Result.Failure(Error.NotFound("404", "Media not found"));
        }

        public bool IsMediaIntoList(Media media)
        {
            if (Collector.Contains(media))
                return true;
            else return false;
        }

        public List<Media> FindMediaByName(string name)
        {
            try
            {
                var foundMedia = Collector.FindAll(x => x.Name.Contains(name));
                return foundMedia;
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted name");
                return null;
            }
        }

        public List<Media> FindMediaByAuthor(string author)
        {
            try
            {
                var foundMedia = Collector.FindAll(x => x.Author.Contains(author));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted author");
                return null;
            }
        }

        public List<Media> FindMediaByGenre(string genre)
        {
            try
            {
                var foundMedia = Collector.FindAll(x => x.Genre.Contains(genre));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted genre");
                return null;
            }
        }

        public List<Media> FindMediaByLanguage(string language)
        {
            try
            {
                var foundMedia = Collector.FindAll(x => x.Language.Contains(language));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted language");
                return null;
            }
        }

        public List<Media> FindMediaByPublicationDate(string publicationDate)
        {
            try
            {
                var foundMedia = Collector.FindAll(x => x.PublicationDate.Contains(publicationDate));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted publication date");
                return null;
            }
        }

        public List<Media> FindMediaByPublisher(string publisher)
        {
            try
            {
                var foundMedia = Collector.FindAll(x => x.Genre.Contains(publisher));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted publisher");
                return null;
            }
        }

        public Book FindBookByISBN(string isbn)
        {
            List<Book> bookList = new List<Book>();
            foreach(Media m in Collector)
            {
                if(m is Book)
                {
                    bookList.Add((Book)m);
                }
            }

            try
            {
                var foundMedia = bookList.Find(x => x.ISBN.Contains(isbn));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted ISBN");
                return null;
            }
        }

        public List<AudioRecording> FindAudioRecordingByFormat(string format)
        {
            List<AudioRecording> audioRecordingList = new List<AudioRecording>();
            foreach (Media m in Collector)
            {
                if (m is AudioRecording)
                {
                    audioRecordingList.Add((AudioRecording)m);
                }
            }

            try
            {
                var foundMedia = audioRecordingList.FindAll(x => x.Format.Contains(format));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted audio format");
                return null;
            }
        }

        public AudioRecording FindAudioRecordingByCatalogCode(string catalogCode)
        {
            List<AudioRecording> audioRecordingList = new List<AudioRecording>();
            foreach (Media m in Collector)
            {
                if (m is AudioRecording)
                {
                    audioRecordingList.Add((AudioRecording)m);
                }
            }

            try
            {
                var foundMedia = audioRecordingList.Find(x => x.CatalogCode.Contains(catalogCode));
                return foundMedia;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No result matches the inserted catalog code");
                return null;
            }
        }
    }
}
