using LibraryDatabase.Domain;
using LibraryDatabase.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Application.Queries.FindMediaByPublisher
{
    public sealed record FindMediaByPublisherQuery(string publisher) : IRequest<Result<List<Media>>>;
}
