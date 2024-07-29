namespace _23_Abstract_classes_and_abstract_methods;

public class Dog : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Bark! woff!!");
    }

    public override void SayName()
    {
        Console.WriteLine("My name is " + Name + ". Woof!");
    }
}