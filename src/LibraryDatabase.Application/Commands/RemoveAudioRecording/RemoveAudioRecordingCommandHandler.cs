using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.RemoveAudioRecording
{
    public sealed class RemoveAudioRecordingCommandHandler : IRequestHandler<RemoveAudioRecordingCommand, Result>
    {
        private readonly IMediaRepository _repository;

        public RemoveAudioRecordingCommandHandler(IMediaRepository repository) => _repository = repository;

        public async Task<Result> Handle(RemoveAudioRecordingCommand request, CancellationToken cancellationToken)
        {
            var check = _repository.IsMediaIntoList(new AudioRecording(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher, request.format, request.catalogCode));
            if (check == false)
                return Result.Failure(Error.Problem("Error", "Audio recording not found"));
            else
                _repository.RemoveMedia(new AudioRecording(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher, request.format, request.catalogCode));
            return Result.Success();
        }
    }
}
