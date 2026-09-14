using LibraryDatabase.Application.Queries.FindBookByISBN;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindAudioRecordingByFormat
{
    public sealed class FindAudioRecordingByFormatQueryHandler : IRequestHandler<FindAudioRecordingByFormatQuery, Result<List<AudioRecording>>>
    {
        private readonly IMediaRepository _repository;

        public FindAudioRecordingByFormatQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<AudioRecording>>> Handle(FindAudioRecordingByFormatQuery request, CancellationToken cancellationToken)
        {
            var recordingsList = _repository.FindAudioRecordingByFormat(request.format);
            return Task.FromResult(Result.Success(recordingsList));
        }
    }
}
