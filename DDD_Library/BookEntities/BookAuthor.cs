using DDD_Library.Common;

namespace DDD_Library.BookEntities;

public class BookAuthor:ValueObject
{
    public BookAuthor(string fullName, DateOnly birthDate, DateOnly deathDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
        DeathDate = deathDate;
    }
    
    // Для действующих, живых авторов
    public BookAuthor(string fullName, DateOnly birthDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
    }

    public string FullName { get; }
    public DateOnly BirthDate { get; }
    public DateOnly DeathDate { get; }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FullName;
    }
}