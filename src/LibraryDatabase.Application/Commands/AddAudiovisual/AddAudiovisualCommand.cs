using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.AddAudiovisual
{
    public sealed record AddAudiovisualCommand(string title, string author, string genre, string language, string publicationDate, string publisher) : IRequest<Result>;
}
