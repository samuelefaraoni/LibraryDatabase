using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByTitle
{
    public sealed class FindMediaByTitleQueryHandler : IRequestHandler<FindMediaByTitleQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByTitleQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByTitleQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByTitle(request.title);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}