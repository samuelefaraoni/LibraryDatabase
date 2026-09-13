using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByLanguage
{
    public sealed class FindMediaByLanguageQueryHandler : IRequestHandler<FindMediaByLanguageQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByLanguageQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByLanguageQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByLanguage(request.language);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}
