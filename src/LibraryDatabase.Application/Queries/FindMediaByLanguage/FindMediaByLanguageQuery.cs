using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByLanguage
{
    public sealed record FindMediaByLanguageQuery(string language) : IRequest<Result<List<Media>>>;
}
