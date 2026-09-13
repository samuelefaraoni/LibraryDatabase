using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByAuthor
{
    public sealed record FindMediaByAuthorQuery(string author) : IRequest<Result<List<Media>>>;
}
