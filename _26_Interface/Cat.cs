namespace _26_Interface;

public class Cat : Animal, ICarnivore
{
    public override void MakeNoise()
    {
        Console.WriteLine("Meow meoww! from abstract animal class");
    }

    public void EatMeat()
    {
        Console.WriteLine("*** eating mice from ICarnivore implemented class ***");
    }
}