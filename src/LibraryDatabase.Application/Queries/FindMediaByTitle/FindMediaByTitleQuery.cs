using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByTitle
{
    public sealed record FindMediaByTitleQuery(string title) : IRequest<Result<List<Media>>>;
}
