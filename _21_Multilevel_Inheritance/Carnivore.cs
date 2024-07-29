namespace _21_Multilevel_Inheritance;

internal class Carnivore : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("I'm a carnivore! *Makes meat-eating noises*");
    }
}