using DDD_Library.Common;

namespace DDD_Library.BookEntities;

public class BookIsReserved:Enumeration
{
    public static BookGenre Free = new(1, nameof(Free));
    public static BookGenre Reserved = new(2, nameof(Reserved));

    public BookIsReserved(int id, string name) : base(id, name)
    {
    }
}