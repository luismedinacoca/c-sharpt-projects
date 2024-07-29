namespace _14_OOP_Classes_and_Objects;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        /* [Classes and Objects]
         * How do we represent a complex data type? i.e. a user? an account?
         * a bicycle? a sandwich? a planet?
         */
        int num1;
        int num2;
        string name;
        
        // creation a new instance of User class
        User usr01 = new User(); 
        usr01.age = 32;
        usr01.firstName = "Alejandro";
        usr01.lastName = "Maldonado";
        
        Console.WriteLine("usr01 first name: " + usr01.firstName);
        Console.WriteLine("usr01 lLast name: " + usr01.lastName);
        Console.WriteLine("usr01 age: " + usr01.age);
        Console.WriteLine("usr01.GetType() {0}", usr01.GetType());
        Console.WriteLine("");
        
        User usr02 = new User();
        usr02.age = 47;
        usr02.firstName = "Darren";
        usr02.lastName = "Carpenter";
        
        Console.WriteLine("First name (usr02): " + usr02.firstName);
        Console.WriteLine("Last name (usr02): " + usr02.lastName);
        Console.WriteLine("Age (usr02): " + usr02.age);
        Console.WriteLine("usr02.GetType() {0}", usr02.GetType());
        
        
        /* [Object-Oriented Programming]
         * - It's a pradigm. Think of a paradigm as a 'style' of programming
         * - It's the way code is organized, which is important when projects are very large!
         */
    }
}