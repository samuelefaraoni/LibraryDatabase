using LibraryDatabase.Application.Queries.FindMediaByPublicationDate;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByPublisher
{
    public sealed class FindMediaByPublisherQueryHandler : IRequestHandler<FindMediaByPublisherQuery, Result<List<Media>>>
    {
        private readonly IMediaRepository _repository;

        public FindMediaByPublisherQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<List<Media>>> Handle(FindMediaByPublisherQuery request, CancellationToken cancellationToken)
        {
            var mediaList = _repository.FindMediaByPublisher(request.publisher);
            return Task.FromResult(Result.Success(mediaList));
        }
    }
}
