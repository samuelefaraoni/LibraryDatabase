using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByGenre
{
    public sealed record FindMediaByGenreQuery(string genre) : IRequest<Result<List<Media>>>;
}
