using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.RemoveAudiovisual
{
    public sealed class RemoveAudiovisualCommandHandler : IRequestHandler<RemoveAudiovisualCommand, Result>
    {
        private readonly IMediaRepository _repository;

        public RemoveAudiovisualCommandHandler(IMediaRepository repository) => _repository = repository;

        public async Task<Result> Handle(RemoveAudiovisualCommand request, CancellationToken cancellationToken)
        {
            var check = _repository.IsMediaIntoList(new Audiovisual(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher));
            if (check == false)
                return Result.Failure(Error.Problem("Error", "Audiovisual not found"));
            else
                _repository.RemoveMedia(new Audiovisual(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher));
            return Result.Success();
        }
    }
}
