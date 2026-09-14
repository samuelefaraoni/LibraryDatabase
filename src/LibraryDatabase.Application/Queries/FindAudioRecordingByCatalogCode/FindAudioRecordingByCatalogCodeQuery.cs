using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindAudioRecordingByCatalogCode
{
    public sealed record FindAudioRecordingByCatalogCodeQuery(string catalogCode) : IRequest<Result<AudioRecording>>;
}
