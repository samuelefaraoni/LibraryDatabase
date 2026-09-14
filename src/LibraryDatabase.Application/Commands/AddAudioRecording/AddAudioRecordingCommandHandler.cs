using LibraryDatabase.Application.Commands.AddAudiovisual;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.AddAudioRecording
{
    public sealed class AddAudioRecordingCommandHandler : IRequestHandler<AddAudioRecordingCommand, Result>
    {
        private readonly IMediaRepository _repository;
        public AddAudioRecordingCommandHandler(IMediaRepository repository) => _repository = repository;
        public Task<Result> Handle(AddAudioRecordingCommand request, CancellationToken cancellationToken)
        {
            var audioRecording = new AudioRecording(request.title, request.author, request.genre, request.language, request.publicationDate, request.publisher, request.format, request.catalogCode);
            var result = _repository.AddMedia(audioRecording);
            if (result.IsFailure)
                return Task.FromResult(Result.Failure(result.Error));
            return Task.FromResult(Result.Success());
        }
    }
}
