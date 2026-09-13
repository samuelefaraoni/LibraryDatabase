using LibraryDatabase.Application.Queries.FindMediaByName;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByGenre
{
    public sealed class FindMediaByGenreQueryHandler : IRequestHandler<FindMediaByGenreQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByGenreQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByGenreQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByGenre(request.genre);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}
