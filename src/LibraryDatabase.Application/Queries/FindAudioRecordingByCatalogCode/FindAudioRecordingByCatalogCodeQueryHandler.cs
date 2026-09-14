using LibraryDatabase.Application.Queries.FindBookByISBN;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindAudioRecordingByCatalogCode
{
    public sealed class FindAudioRecordingByCatalogCodeQueryHandler : IRequestHandler<FindAudioRecordingByCatalogCodeQuery, Result<AudioRecording>>
    {
        private readonly IMediaRepository _repository;

        public FindAudioRecordingByCatalogCodeQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<AudioRecording>> Handle(FindAudioRecordingByCatalogCodeQuery request, CancellationToken cancellationToken)
        {
            var audioRecording = _repository.FindAudioRecordingByCatalogCode(request.catalogCode);
            return Task.FromResult(Result.Success(audioRecording));
        }
    }
}
