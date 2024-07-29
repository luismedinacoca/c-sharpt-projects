namespace _20_Method_overriding;

class Program
{
    static void Main(string[] args)
    {
        // create a new animal object
        Animal animal = new Animal();
        animal.Name = "Henry";
        animal.Age = 5;
        
        // Create a new dog object
        Dog dog = new Dog();
        dog.Name = "Lassie";
        dog.Age = 12;
        
        // Create a new Cat
        Cat cat = new Cat();
        cat.Name = "Felix";
        cat.Age = 1;
        
        // Do some stuff:
        animal.SayName();
        animal.SayAge();
        animal.MakeNoise();
        Console.WriteLine("");
        dog.SayName();
        dog.SayAge();
        dog.MakeNoise();
        Console.WriteLine("");
        cat.SayName();
        cat.SayAge();
        cat.MakeNoise();
    }
}