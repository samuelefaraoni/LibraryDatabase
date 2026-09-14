using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.AddAudioRecording
{
    public sealed record AddAudioRecordingCommand(string title, string author, string genre, string language, string publicationDate, string publisher, string format, string catalogCode) : IRequest<Result>;
}
