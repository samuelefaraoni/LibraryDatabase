using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.RemoveAudiovisual
{
    public sealed record RemoveAudiovisualCommand(string name, string[] author, string genre, string language, string publicationDate, string publisher) : IRequest<Result>;
}
