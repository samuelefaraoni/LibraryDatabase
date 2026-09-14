using LibraryDatabase.Application.Commands.AddMediaCommand;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.AddAudiovisual
{
    public sealed class AddAudiovisualCommandHandler : IRequestHandler<AddAudiovisualCommand, Result>
    {
        private readonly IMediaRepository _repository;
        public AddAudiovisualCommandHandler(IMediaRepository repository) => _repository = repository;
        public Task<Result> Handle(AddAudiovisualCommand request, CancellationToken cancellationToken)
        {
            var audiovisual = new Audiovisual(request.title, request.author, request.genre, request.language, request.publicationDate, request.publisher);
            var result = _repository.AddMedia(audiovisual);
            if (result.IsFailure)
                return Task.FromResult(Result.Failure(result.Error));
            return Task.FromResult(Result.Success());
        }
    }
}
