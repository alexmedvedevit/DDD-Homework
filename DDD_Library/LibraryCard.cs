using DDD_Library.Common;

namespace DDD_Library;

public class LibraryCard:ValueObject
{
    public long Value { get; }
        
    public LibraryCard(long card)
    {
        Value = card;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}