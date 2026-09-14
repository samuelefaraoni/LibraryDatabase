using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindBookByISBN
{
    public sealed record FindBookByISBNQuery(string isbn) : IRequest<Result<Book>>;
}
