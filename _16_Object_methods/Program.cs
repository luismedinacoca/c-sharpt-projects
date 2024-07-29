namespace _16_Object_methods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        
        //Setup 3 users and add them to a List
        List<User> users = new List<User>();

        //creating users
        User user1 = new User("Tony", "Smith", 70);
        User user2 = new User("Bob", "Holmes", 21);
        User user3 = new User("Tyrone", "Johnson", 42);

        //adding users to list:
        users.Add(user1);
        users.Add(user2);
        users.Add(user3);
        
        //Output all user info to the window:
        foreach (User usr in users)
        {
            Console.WriteLine("First Name: " + usr.firstName);
            Console.WriteLine("Last Name: " + usr.lastName);
            Console.WriteLine("Age: " + usr.userAge);
            Console.WriteLine("**** using internal method ****");
            Console.WriteLine("👉🏽 is Retired? {0}", usr.IsRetired());
            Console.WriteLine("**** using logic ****");
            bool retired = (usr.userAge >= 66);
            Console.WriteLine("➡️ Retired: {0}", retired);
            Console.WriteLine("");
        }
        
        //Keep console window open
        Console.ReadLine();
    }
}