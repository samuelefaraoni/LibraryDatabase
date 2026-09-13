using LibraryDatabase.Domain;
using LibraryDatabase.Domain.Repositories;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Commands.RemoveMediaCommand
{
    public sealed class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand, Result>
    {
        private readonly IMediaRepository _repository;

        public RemoveBookCommandHandler(IMediaRepository repository) => _repository = repository;

        public async Task<Result> Handle(RemoveBookCommand request, CancellationToken cancellationToken)
        {
            var check = _repository.IsMediaIntoList(new Book(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher, request.isbn));
            if (check == false)
                return Result.Failure(Error.Problem("Error", "Book not found"));
            else
                _repository.RemoveMedia(new Book(request.name, request.author, request.genre, request.language, request.publicationDate, request.publisher, request.isbn));
                return Result.Success();
        }
    } 
}
