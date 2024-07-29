namespace _15_OOP_Constructors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        
        //Create a new User Object:
        User usr = new User();
        usr.firstName = "Bob";
        usr.lastName = "Smith";
        usr.userAge = 32;
        
        //Output user info to window:
        Console.WriteLine("First Name: " + usr.firstName);
        Console.WriteLine("Last Name: " + usr.lastName);
        Console.WriteLine("Age: " + usr.userAge);
        Console.WriteLine("");
        
        
        //Create a brand-new User object:
        User usr01 = new User("Tony", "Stark", 41);
        Console.WriteLine(" ===========================");
        /*
        // using the constructor, so we commented this old way:
        usr01.firstName = "Tony";
        usr01.lastName = "Stark";
        usr01.userAge = 41;
        */
        
        //Output user info to window:
        Console.WriteLine("First Name: " + usr01.firstName);
        Console.WriteLine("Last Name: " + usr01.lastName);
        Console.WriteLine("Age: " + usr01.userAge);
        Console.WriteLine("");
    }
}