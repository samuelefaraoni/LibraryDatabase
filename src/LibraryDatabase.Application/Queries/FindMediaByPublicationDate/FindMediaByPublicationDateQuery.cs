using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByPublicationDate
{
    public sealed record FindMediaByPublicationDateQuery(string publicationDate) : IRequest<Result<List<Media>>>;
}
