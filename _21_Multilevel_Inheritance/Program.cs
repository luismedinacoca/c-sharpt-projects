namespace _21_Multilevel_Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a new animal object
        Animal animal = new Animal();
        animal.Name = "Henry";

        // Create a new dog object
        Dog dog = new Dog();
        dog.Name = "Lassie";
        
        // Create a new cat object
        Cat cat = new Cat();
        cat.Name = "Felix";
        
        // Do some stuff:
        animal.MakeNoise();
        dog.MakeNoise();
        cat.MakeNoise();
    }
}