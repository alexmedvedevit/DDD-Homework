using MediatR;

namespace DDD_Library.Commands;

public class CreateBookCommand : IRequest<long>
{
    public long LibraryCard { get; init; }
    public string Title { get; init; }
    public long InventoryNum { get; init; }
    public string Author { get; init; }
    public int Genre { get; init; }
    public int ReservationType { get; init; }
}