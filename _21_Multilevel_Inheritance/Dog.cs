namespace _21_Multilevel_Inheritance;

internal class Dog : Carnivore
{
    public override void MakeNoise()
    {
        Console.WriteLine("woof woof!");
    }
}