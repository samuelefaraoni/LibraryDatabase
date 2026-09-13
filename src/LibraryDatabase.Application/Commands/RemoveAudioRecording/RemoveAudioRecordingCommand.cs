using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.RemoveAudioRecording
{
    public sealed record RemoveAudioRecordingCommand(string name, string[] author, string genre, string language, string publicationDate, string publisher, string format, string catalogCode) : IRequest<Result>;
}
