using LibraryDatabase.ConsoleInterface.Controller;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.Infrastructure.Repositories.InMemory;

class Program
{
    static void Main()
    {
        IMediaRepository repository = new InMemoryMediaRepository();
        Controller controller = new Controller(repository);

        bool exit = false;

        while (exit == false)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an an action\n-Add Media.\n-Remove Media\n-Search Media\n-Exit");
            Console.ResetColor();
            string? choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "Add Media":
                    controller.AddMedia();
                    break;

                case "Remove Media":
                    controller.RemoveMedia();
                    break;

                case "Search Media":

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Select which search filter to apply\n-Search by title\n-Search by author\n-Search by genre\n-Search by Language\n-Search by publication date\n-Search by publisher\n-Search by ISBN(Books only)\n-Search by format(Audio recordings only)\n-Search by catalog code(Audio recordings only)");
                    Console.ResetColor();
                    string? searchFilter = Console.ReadLine()?.Trim();

                    switch (searchFilter)
                    {
                        case "Search by title":
                            controller.FindMediaByTitle();
                            break;

                        case "Search by author":
                            controller.FindMediaByAuthor();
                            break;

                        case "Search by genre":
                            controller.FindMediaByGenre();
                            break;

                        case "Search by language":
                            controller.FindMediaByLanguage();
                            break;

                        case "Search by publication date":
                            controller.FindMediaByPublicationDate();
                            break;

                        case "Search by publisher":
                            controller.FindMediaByPublisher();
                            break;

                        case "Search by ISBN":
                            controller.FindBookByISBN();
                            break;

                        case "Search by format":
                            controller.FindAudioRecordingByFormat();
                            break;

                        case "Search by catalog code":
                            controller.FindAudioRecordingByCatalogCode();
                            break;

                        default:
                            Console.WriteLine("Invalid choice(Check for eventual typos)");
                            break;
                    }

                    break;

                case "Exit":
                    {
                        exit = true;
                        break;
                    }

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}