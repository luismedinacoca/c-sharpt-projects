namespace _26_Interface;

class Program
{
    static void Main(string[] args)
    {
        /*
        IAnimal animal = new IAnimal();
        // Interface does not allow to create an object from that
        */
        
        // create a new dog object
        Dog dog = new Dog();
        dog.MakeNoise();  //from IAnimal
        dog.EatMeat();

        Cat cat = new Cat();
        cat.MakeNoise(); // from abstract Animal
        cat.EatMeat();
        
        _MakeNoise(dog);
        //_MakeNoise(cat); // cat not implement IAnimal
    }

    public static void _MakeNoise(IAnimal animal)
    {
        Console.WriteLine(">> from static void method");
        animal.MakeNoise();
    }
}