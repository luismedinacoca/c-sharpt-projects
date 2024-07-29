namespace _16_Object_methods;

public class User
{
    internal string firstName;
    internal string lastName;
    internal int userAge;

    //Empty Constructor -> used when call: new User();
    internal User()
    {
    }

    // Constructor:
    internal User(string FirstName, string LastName, int Age)
    {
        firstName = FirstName;
        lastName = LastName;
        userAge = Age;
    }

    internal bool IsRetired()
    {
        return (userAge >= 66);
    }
}