namespace _20_Method_overriding;

public class Cat : Animal
{
    public override void MakeNoise() 
    {
        Console.WriteLine("meow meow!");
    }
}