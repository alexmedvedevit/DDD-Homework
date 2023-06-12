namespace DDD_Library.Models;
public class BookDto
{
    public long LibraryCard { get; init; }
    public string Title { get; init; }
    public long InventoryNum { get; init; }
    public string Author { get; init; }
    public int Genre { get; init; }
    public int ReservationType { get; init; }
}
