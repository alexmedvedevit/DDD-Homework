using DDD_Library.Common;

namespace DDD_Library.UserEntities;

public class UserGender:Enumeration
{
    public static UserGender Male = new(1, nameof(Male));
    public static UserGender Female = new(2, nameof(Female));
    
    public UserGender(int id, string name) : base(id, name)
    {
    }
}