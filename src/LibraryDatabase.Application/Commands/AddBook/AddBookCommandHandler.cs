using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LibraryDatabase.Application.Commands.AddMediaCommand
{
    public sealed class AddBookCommandHandler :IRequestHandler<AddBookCommand, Result>
    {
        private readonly IMediaRepository _repository;
        public AddBookCommandHandler(IMediaRepository repository) => _repository = repository;
        public Task<Result> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher, request.isbn);
            var result = _repository.AddMedia(book);
            if (result.IsFailure)
                return Task.FromResult(Result.Failure(result.Error));
            return Task.FromResult(Result.Success());
        }
    }
}
