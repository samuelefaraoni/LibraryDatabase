using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByPublicationDate
{
    public sealed class FindMediaByPublicationDateQueryHandler : IRequestHandler<FindMediaByPublicationDateQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByPublicationDateQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByPublicationDateQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByPublicationDate(request.publicationDate);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}
