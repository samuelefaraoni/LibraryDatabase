using LibraryDatabase.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain.Repositories
{
    public interface IMediaRepository
    {
        Result AddMedia(Media media);
        Result RemoveMedia(Media media);
        string GetMediaInfo(Media media);
        bool IsMediaIntoList(Media media);
        List<Media> FindMediaByName(string name);
        List<Media> FindMediaByAuthor(string author);
        List<Media> FindMediaByGenre(string genre);
        List<Media> FindMediaByLanguage(string language);
        List<Media> FindMediaByPublicationDate(string publicationDate);
        List<Media> FindMediaByPublisher(string publisher);
        Book FindBookByISBN(string isbn);
        List<AudioRecording> FindAudioRecordingByFormat(string format);
        AudioRecording FindAudioRecordingByCatalogCode(string catalogCode);
    }
}
