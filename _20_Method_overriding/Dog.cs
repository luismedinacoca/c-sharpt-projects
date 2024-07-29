namespace _20_Method_overriding;

public class Dog : Animal
{
    public override void MakeNoise() 
    {
        Console.WriteLine("Woof Woof!");
    }
}