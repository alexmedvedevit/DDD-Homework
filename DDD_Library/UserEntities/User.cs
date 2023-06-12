using DDD_Library.Common;

namespace DDD_Library.UserEntities;

public class User:Entity,IAggregationRoot
{
    public User(UserName name, DateOnly birthDate, UserGender gender)
    {
        Name = name;
        BirthDate = birthDate;
        SetGender(gender);
    }

    public UserName Name { get; }
    public DateOnly BirthDate { get; }

    public UserGender Gender;

    public void SetGender(UserGender gender)
    {
        if (gender is not null)
            this.Gender = gender;
        else
            this.Gender = null;
    }
}