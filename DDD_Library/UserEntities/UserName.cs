namespace DDD_Library.UserEntities;
using DDD_Library.Common;

public class UserName:ValueObject
{
    public UserName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        FullName = this.LastName + " " + this.FirstName;
    }

    public string FirstName { get; }
    public string LastName { get; }

    public string FullName;
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FullName;
    }
}




