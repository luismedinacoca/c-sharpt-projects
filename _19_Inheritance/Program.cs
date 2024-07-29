namespace _19_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Create a new object
        Animal animal = new Animal();
        animal.Name = "Rocky";
        animal.Age = 7;
        
        // Do some stuff!
        animal.SayName();
        animal.SayAge();
        
        // Create a new Dog object
        Dog dog = new Dog();
        dog.Name = "Bingo";
        dog.Age = 3;
        
        // Do some dog stuff:
        dog.SayName();
        dog.SayAge();
        dog.Bark();

    }
}