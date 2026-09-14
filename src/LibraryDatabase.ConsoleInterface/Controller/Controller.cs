using LibraryDatabase.Application.Mappers;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.ConsoleInterface.Controller
{
    public class Controller
    {
        private readonly IMediaRepository _repository;

        public Controller(IMediaRepository repository)
        {
            _repository = repository;
        }

        public void AddMedia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type in the media type you want to register.\n-Book.\n-Audiovisual.\n-Audio Recording");
            Console.ResetColor();

            string? selection = Console.ReadLine()?.Trim();
            switch (selection)
            {
                case "Book":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the title of the media");
                    Console.ResetColor();
                    string? bookTitle = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookTitle))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: A title must be inserted");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the author of the media");
                    Console.ResetColor();
                    string? bookAuthor = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookAuthor))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have an author");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the genre of the media");
                    Console.ResetColor();
                    string? bookGenre = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookGenre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must fit inside a genre");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the language of the media");
                    Console.ResetColor();
                    string? bookLanguage = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookLanguage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have a language");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
                    Console.ResetColor();
                    string? bookPublicationDate = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookPublicationDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid date");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publisher of the media('Self-Published' if the media has no publisher)");
                    Console.ResetColor();
                    string? bookPublisher = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookPublisher))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid publisher");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the book's ISBN(without spaces)");
                    Console.ResetColor();
                    string? isbn = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookPublicationDate) || isbn.Length != 13)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid ISBN length");
                        Console.ResetColor();
                        break;
                    }

                    var book = new Book(bookTitle, bookAuthor, bookGenre, bookLanguage, bookPublicationDate, bookPublisher, isbn);

                    var bookAddResult = _repository.AddMedia(book);

                    if (bookAddResult.IsFailure)
                    {
                        Console.WriteLine("Error while adding media. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Media added succesfully to the database");
                    }
                    break;

                case "Audiovisual":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the title of the media");
                    Console.ResetColor();
                    string? audiovisualTitle = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualTitle))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: A title must be inserted");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the author of the media");
                    Console.ResetColor();
                    string? audiovisualAuthor = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualAuthor))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have an author");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the genre of the media");
                    Console.ResetColor();
                    string? audiovisualGenre = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualGenre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must fit inside a genre");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the language of the media");
                    Console.ResetColor();
                    string? audiovisualLanguage = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualLanguage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have a language");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
                    Console.ResetColor();
                    string? audiovisualPublicationDate = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualPublicationDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid date");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publisher of the media('Self-Published' if the media has no publisher)");
                    Console.ResetColor();
                    string? audiovisualPublisher = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualPublisher))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid publisher");
                        Console.ResetColor();
                        break;
                    }

                    var audiovisual = new Audiovisual(audiovisualTitle, audiovisualAuthor, audiovisualGenre, audiovisualLanguage, audiovisualPublicationDate, audiovisualPublisher);

                    var audiovisualAddResult = _repository.AddMedia(audiovisual);

                    if (audiovisualAddResult.IsFailure)
                    {
                        Console.WriteLine("Error while adding media. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Media added succesfully to the database");
                    }

                    break;

                case "Audio Recording":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the title of the media");
                    Console.ResetColor();
                    string? audioRecordingTitle = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingTitle))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: A title must be inserted");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the author of the media");
                    Console.ResetColor();
                    string? audioRecordingAuthor = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingAuthor))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have an author");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the genre of the media");
                    Console.ResetColor();
                    string? audioRecordingGenre = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingGenre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must fit inside a genre");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the language of the media");
                    Console.ResetColor();
                    string? audioRecordingLanguage = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingLanguage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have a language");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
                    Console.ResetColor();
                    string? audioRecordingPublicationDate = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingPublicationDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid date");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publisher of the media('Self-Published' if the media has no publisher)");
                    Console.ResetColor();
                    string? audioRecordingPublisher = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingPublisher))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid publisher");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the format of the audio recording(vinyl, CD, cassette ecc.)");
                    Console.ResetColor();
                    string? audioRecordingFormat = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingFormat))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid format");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the catalog code of the audio recording");
                    Console.ResetColor();
                    string? audioRecordingCatalogCode = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingCatalogCode))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid format");
                        Console.ResetColor();
                        break;
                    }

                    var audioRecording = new AudioRecording(audioRecordingTitle, audioRecordingAuthor, audioRecordingGenre, audioRecordingLanguage, audioRecordingPublicationDate, audioRecordingPublisher, audioRecordingFormat, audioRecordingCatalogCode);

                    var audioRecordingAddResult = _repository.AddMedia(audioRecording);

                    if (audioRecordingAddResult.IsFailure)
                    {
                        Console.WriteLine("Error while adding media. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Media added succesfully to the database");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid choice(check for eventual typos)");
                    break;
            }

        }

        public void RemoveMedia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type in the media type you want to remove.\n-Book.\n-Audiovisual.\n-Audio Recording");
            Console.ResetColor();

            string? selection = Console.ReadLine()?.Trim();
            switch (selection)
            {
                case "Book":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the title of the media");
                    Console.ResetColor();
                    string? bookTitle = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookTitle))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: A title must be inserted");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the author of the media");
                    Console.ResetColor();
                    string? bookAuthor = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookAuthor))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have an author");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the genre of the media");
                    Console.ResetColor();
                    string? bookGenre = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookGenre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must fit inside a genre");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the language of the media");
                    Console.ResetColor();
                    string? bookLanguage = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookLanguage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have a language");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
                    Console.ResetColor();
                    string? bookPublicationDate = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookPublicationDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid date");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publisher of the media('Self-Published' if the media has no publisher)");
                    Console.ResetColor();
                    string? bookPublisher = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookPublisher))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid publisher");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the book's ISBN(without spaces)");
                    Console.ResetColor();
                    string? isbn = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(bookPublicationDate) || isbn.Length != 13)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid ISBN length");
                        Console.ResetColor();
                        break;
                    }

                    var book = new Book(bookTitle, bookAuthor, bookGenre, bookLanguage, bookPublicationDate, bookPublisher, isbn);

                    var bookAddResult = _repository.RemoveMedia(book);

                    if (bookAddResult.IsFailure)
                    {
                        Console.WriteLine("Error while removing media. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Media removed succesfully from the database");
                    }
                    break;

                case "Audiovisual":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the title of the media");
                    Console.ResetColor();
                    string? audiovisualTitle = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualTitle))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: A title must be inserted");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the author of the media");
                    Console.ResetColor();
                    string? audiovisualAuthor = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualAuthor))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have an author");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the genre of the media");
                    Console.ResetColor();
                    string? audiovisualGenre = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualGenre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must fit inside a genre");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the language of the media");
                    Console.ResetColor();
                    string? audiovisualLanguage = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualLanguage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have a language");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
                    Console.ResetColor();
                    string? audiovisualPublicationDate = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualPublicationDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid date");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publisher of the media('Self-Published' if the media has no publisher)");
                    Console.ResetColor();
                    string? audiovisualPublisher = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audiovisualPublisher))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid publisher");
                        Console.ResetColor();
                        break;
                    }

                    var audiovisual = new Audiovisual(audiovisualTitle, audiovisualAuthor, audiovisualGenre, audiovisualLanguage, audiovisualPublicationDate, audiovisualPublisher);

                    var audiovisualAddResult = _repository.RemoveMedia(audiovisual);

                    if (audiovisualAddResult.IsFailure)
                    {
                        Console.WriteLine("Error while removing media. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Media removed succesfully from the database");
                    }

                    break;

                case "Audio Recording":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the title of the media");
                    Console.ResetColor();
                    string? audioRecordingTitle = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingTitle))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: A title must be inserted");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the author of the media");
                    Console.ResetColor();
                    string? audioRecordingAuthor = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingAuthor))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have an author");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the genre of the media");
                    Console.ResetColor();
                    string? audioRecordingGenre = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingGenre))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must fit inside a genre");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the language of the media");
                    Console.ResetColor();
                    string? audioRecordingLanguage = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingLanguage))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Media must have a language");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
                    Console.ResetColor();
                    string? audioRecordingPublicationDate = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingPublicationDate))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid date");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the publisher of the media('Self-Published' if the media has no publisher)");
                    Console.ResetColor();
                    string? audioRecordingPublisher = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingPublisher))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid publisher");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the format of the audio recording(vinyl, CD, cassette ecc.)");
                    Console.ResetColor();
                    string? audioRecordingFormat = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingFormat))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid format");
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Insert the catalog code of the audio recording");
                    Console.ResetColor();
                    string? audioRecordingCatalogCode = Console.ReadLine()?.Trim();

                    if (String.IsNullOrEmpty(audioRecordingCatalogCode))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid catalog code");
                        Console.ResetColor();
                        break;
                    }

                    var audioRecording = new AudioRecording(audioRecordingTitle, audioRecordingAuthor, audioRecordingGenre, audioRecordingLanguage, audioRecordingPublicationDate, audioRecordingPublisher, audioRecordingFormat, audioRecordingCatalogCode);

                    var audioRecordingAddResult = _repository.RemoveMedia(audioRecording);

                    if (audioRecordingAddResult.IsFailure)
                    {
                        Console.WriteLine("Error while removing media. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Media removed succesfully from the database");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid choice(check for eventual typos)");
                    break;
            }
        }

        public void FindMediaByTitle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the title of the media");
            Console.ResetColor();
            string? mediaTitle = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(mediaTitle))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid title");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindMediaByTitle(mediaTitle);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (Media media in results)
            {
                if (media is Book)
                {
                    var book = (Book)media;
                    var bookDto = BookMapper.ToDto(book);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bookDto);
                    Console.ResetColor();
                }
                else if (media is Audiovisual)
                {
                    var audiovisual = (Audiovisual)media;
                    var audiovisualDto = AudiovisualMapper.ToDto(audiovisual);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audiovisualDto);
                    Console.ResetColor();
                }
                else
                {
                    var audioRecording = (AudioRecording)media;
                    var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audioRecordingDto);
                    Console.ResetColor();
                }

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindMediaByAuthor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the author of the media");
            Console.ResetColor();
            string? mediaAuthor = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(mediaAuthor))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid author");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindMediaByAuthor(mediaAuthor);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (Media media in results)
            {
                if (media is Book)
                {
                    var book = (Book)media;
                    var bookDto = BookMapper.ToDto(book);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bookDto);
                    Console.ResetColor();
                }
                else if (media is Audiovisual)
                {
                    var audiovisual = (Audiovisual)media;
                    var audiovisualDto = AudiovisualMapper.ToDto(audiovisual);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audiovisualDto);
                    Console.ResetColor();
                }
                else
                {
                    var audioRecording = (AudioRecording)media;
                    var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audioRecordingDto);
                    Console.ResetColor();
                }

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindMediaByGenre()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the genre of the media");
            Console.ResetColor();
            string? mediaGenre = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(mediaGenre))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid genre");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindMediaByGenre(mediaGenre);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (Media media in results)
            {
                if (media is Book)
                {
                    var book = (Book)media;
                    var bookDto = BookMapper.ToDto(book);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bookDto);
                    Console.ResetColor();
                }
                else if (media is Audiovisual)
                {
                    var audiovisual = (Audiovisual)media;
                    var audiovisualDto = AudiovisualMapper.ToDto(audiovisual);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audiovisualDto);
                    Console.ResetColor();
                }
                else
                {
                    var audioRecording = (AudioRecording)media;
                    var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audioRecordingDto);
                    Console.ResetColor();
                }

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindMediaByLanguage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the language of the media");
            Console.ResetColor();
            string? mediaLanguage = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(mediaLanguage))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid language");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindMediaByLanguage(mediaLanguage);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (Media media in results)
            {
                if (media is Book)
                {
                    var book = (Book)media;
                    var bookDto = BookMapper.ToDto(book);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bookDto);
                    Console.ResetColor();
                }
                else if (media is Audiovisual)
                {
                    var audiovisual = (Audiovisual)media;
                    var audiovisualDto = AudiovisualMapper.ToDto(audiovisual);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audiovisualDto);
                    Console.ResetColor();
                }
                else
                {
                    var audioRecording = (AudioRecording)media;
                    var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audioRecordingDto);
                    Console.ResetColor();
                }

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindMediaByPublicationDate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the publication date of the media(Using DD/MM/YYYY format)");
            Console.ResetColor();
            string? mediaPublicationDate = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(mediaPublicationDate))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid date");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindMediaByPublicationDate(mediaPublicationDate);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (Media media in results)
            {
                if (media is Book)
                {
                    var book = (Book)media;
                    var bookDto = BookMapper.ToDto(book);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bookDto);
                    Console.ResetColor();
                }
                else if (media is Audiovisual)
                {
                    var audiovisual = (Audiovisual)media;
                    var audiovisualDto = AudiovisualMapper.ToDto(audiovisual);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audiovisualDto);
                    Console.ResetColor();
                }
                else
                {
                    var audioRecording = (AudioRecording)media;
                    var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audioRecordingDto);
                    Console.ResetColor();
                }

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindMediaByPublisher()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the publisher date of the media");
            Console.ResetColor();
            string? mediaPublisher = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(mediaPublisher))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid publisher");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindMediaByPublisher(mediaPublisher);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (Media media in results)
            {
                if (media is Book)
                {
                    var book = (Book)media;
                    var bookDto = BookMapper.ToDto(book);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(bookDto);
                    Console.ResetColor();
                }
                else if (media is Audiovisual)
                {
                    var audiovisual = (Audiovisual)media;
                    var audiovisualDto = AudiovisualMapper.ToDto(audiovisual);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audiovisualDto);
                    Console.ResetColor();
                }
                else
                {
                    var audioRecording = (AudioRecording)media;
                    var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(audioRecordingDto);
                    Console.ResetColor();
                }

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindBookByISBN()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the isbn of the book");
            Console.ResetColor();
            string? isbn = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(isbn))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid publisher");
                Console.ResetColor();
                return;
            }

            var result = _repository.FindBookByISBN(isbn);

            if (result == null)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nRESULT FOUND:");
            Console.ResetColor();

            var bookDto = BookMapper.ToDto(result);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(bookDto);
            Console.ResetColor();

            Console.WriteLine("-----------------------------------");
        }

        public void FindAudioRecordingByFormat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the format of the audio recording");
            Console.ResetColor();
            string? format = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(format))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid format");
                Console.ResetColor();
                return;
            }

            var results = _repository.FindAudioRecordingByFormat(format);

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{results.Count} RESULTS FOUND:");
            Console.ResetColor();

            foreach (AudioRecording audioRecording in results)
            {
                var audioRecordingDto = AudioRecordingMapper.ToDto(audioRecording);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(audioRecordingDto);
                Console.ResetColor();

            }

            Console.WriteLine("-----------------------------------");
        }

        public void FindAudioRecordingByCatalogCode()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insert the catalog code of the audio recording");
            Console.ResetColor();
            string? catalogCode = Console.ReadLine()?.Trim();

            if (String.IsNullOrEmpty(catalogCode))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid catalog code");
                Console.ResetColor();
                return;
            }

            var result = _repository.FindAudioRecordingByCatalogCode(catalogCode);

            if (result == null)
            {
                Console.WriteLine("The search has returned no results");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nRESULT FOUND:");
            Console.ResetColor();

            var audioRecordingDto = AudioRecordingMapper.ToDto(result);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(audioRecordingDto);
            Console.ResetColor();

            Console.WriteLine("-----------------------------------");
        }
    }
}
