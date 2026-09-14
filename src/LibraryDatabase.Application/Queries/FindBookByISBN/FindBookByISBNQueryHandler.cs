using LibraryDatabase.Application.Queries.FindMediaByTitle;
using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindBookByISBN
{
    public sealed class FindBookByISBNQueryHandler : IRequestHandler<FindBookByISBNQuery, Result<Book>>
    {
        private readonly IMediaRepository _repository;

        public FindBookByISBNQueryHandler(IMediaRepository repository) => _repository = repository;

        public Task<Result<Book>> Handle(FindBookByISBNQuery request, CancellationToken cancellationToken)
        {
            var book = _repository.FindBookByISBN(request.isbn);
            return Task.FromResult(Result.Success(book));
        }
    }
}
