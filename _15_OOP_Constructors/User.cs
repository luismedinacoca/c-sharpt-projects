namespace _15_OOP_Constructors;

public class User
{
    internal string firstName;
    internal string lastName;
    internal int userAge;

    // Constructor:
    internal User(string FirstName, string LastName, int Age)
    {
        Console.WriteLine(">>> Setting up a new user <<<");
        firstName = FirstName;
        lastName = LastName;
        userAge = Age;
    }
    
    //Empty Constructor -> used when call: new User();
    internal User()
    {
    }   
}