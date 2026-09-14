using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindAudioRecordingByFormat
{
    public sealed record FindAudioRecordingByFormatQuery(string format) : IRequest<Result<List<AudioRecording>>>;
}
