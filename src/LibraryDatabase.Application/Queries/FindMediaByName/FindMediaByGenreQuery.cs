using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByName
{
    public sealed record FindMediaByGenreQuery(string name) : IRequest<Result<List<Media>>>;
}
