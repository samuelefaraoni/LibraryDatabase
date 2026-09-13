using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByName
{
    public sealed class FindMediaByNameQueryHandler : IRequestHandler<FindMediaByGenreQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByNameQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByGenreQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByName(request.name);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}