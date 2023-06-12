namespace DDD_Library.BookEntities;
using DDD_Library.Common;

public class BookInventoryNum:ValueObject
{
    public BookInventoryNum(long value)
    {
        Value = value;
    }
    public long Value { get; }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}