using DDD_Library.Common;

namespace DDD_Library.BookEntities;

public class Book:Entity,IAggregationRoot
{
    public Book(BookInventoryNum inv, string title, BookAuthor author, long pagesCount, BookGenre genre, BookIsReserved reservation)
    {
        InventoryNum = inv;
        Title = title;
        Author = author;
        PagesCount = pagesCount;
        SetGenre(genre);
        SetReservationType(reservation);
    }

    public BookInventoryNum InventoryNum { get; }
    public string Title { get; }
    public BookAuthor Author { get; }
    public Int64 PagesCount { get; }

    public BookGenre Genre;

    public BookIsReserved IsReserved;

    public void SetGenre(BookGenre genre)
    {
        if (genre is not null)
            this.Genre = genre;
        else
            this.Genre = null;
    }
    
    public void SetReservationType(BookIsReserved reservation)
    {
        if (reservation is not null)
            this.IsReserved = reservation;
        else
            this.IsReserved = null;
    }

    public override int GetHashCode()
    {
        if (!IsTransient())
        {
            if (!_requestedHashCode.HasValue)
                _requestedHashCode = HashCode.Combine(Id,
                    InventoryNum,
                    Title,
                    Author,
                    PagesCount,
                    31);

            return _requestedHashCode.Value;
        }
        else
            return HashCode.Combine(Id,
                Title,
                Author,
                PagesCount);

    }
}