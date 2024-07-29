namespace _25_Base_keyword;

class Program
{
    static void Main(string[] args)
    {
        // Create a new dog object
        Dog dog = new Dog("Bruno", 4, "Pitbull");
        
        // Do some stuff:
        dog.Info();
        dog.MakeNoise();
    }
}