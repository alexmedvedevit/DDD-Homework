using DDD_Library.Models;
using MediatR;

namespace DDD_Library.Commands;

public class GetBookCommand : IRequest<GetBookResult>
{
    public IReadOnlyList<BookQuantityDto> Books { get; init; }
}

public enum GetBookResult
{
    Available = 0,
    NotAvailable = 1,
}