namespace _23_Abstract_classes_and_abstract_methods;

class Program
{
    static void Main(string[] args)
    {
        // create a new animal
        //Animal animal = new Animal();
        //animal.Name = "Henry";
        
        // Create a new Dog object
        Dog dog = new Dog();
        dog.Name = "Lassie";
        
        // Create a new Cat object
        Cat cat = new Cat();
        cat.Name = "Felix";
        
        // Do some stuff:
        //animal.SayName();
        //animal.MakeNoise();
        dog.SayName();
        dog.MakeNoise();
        cat.SayName();
        cat.MakeNoise();
    }
}