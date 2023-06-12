using DDD_Library.Common;

namespace DDD_Library.BookEntities;

public class BookGenre:Enumeration
{
    public static BookGenre Novel = new(1, nameof(Novel));
    public static BookGenre Detective = new(2, nameof(Detective));
    public static BookGenre Horror = new(3, nameof(Horror));
    public static BookGenre NonFiction = new(4, nameof(NonFiction));
    public static BookGenre Fairytale = new(5, nameof(Fairytale));
    public static BookGenre Poetry = new(6, nameof(Poetry));
    public static BookGenre TheatrePlay = new(7, nameof(TheatrePlay));
    public static BookGenre Mythology = new(8, nameof(Mythology));
    
    public BookGenre(int id, string name) : base(id, name)
    {
    }
}