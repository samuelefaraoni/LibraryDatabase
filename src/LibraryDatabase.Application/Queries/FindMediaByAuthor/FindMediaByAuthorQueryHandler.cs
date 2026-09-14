using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByAuthor
{
    public sealed class FindMediaByAuthorQueryHandler : IRequestHandler<FindMediaByAuthorQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByAuthorQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByAuthorQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByAuthor(request.author);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}
