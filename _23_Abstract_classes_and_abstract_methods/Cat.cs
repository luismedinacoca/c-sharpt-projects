namespace _23_Abstract_classes_and_abstract_methods;

public class Cat : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("meow meoww!!");
    }

    public override void SayName()
    {
        Console.WriteLine("My name is " + Name + ". Meoww!");
    }
}