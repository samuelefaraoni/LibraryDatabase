using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.RemoveMediaCommand
{
    public sealed record RemoveBookCommand(string title, string author, string genre, string language, string publicationDate, string publisher, string isbn) : IRequest<Result>;
}
