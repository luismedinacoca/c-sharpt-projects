namespace _26_Interface;

public class Dog : IAnimal, ICarnivore
{
    // it comes from IAnimal (interface)
    public void MakeNoise()
    {
        Console.WriteLine("Barking: Woof woof!! from IAnimal implemented class");
    }
    
    public void EatMeat()
    {
        Console.WriteLine("** Eat meat! from ICarnivore implemented class**");
    }
    
    /* //in case this method comes from abstract class, OVERRIDE is mandatory
    public override void MakeNoise()
    {
        Console.WriteLine("Barking: Woof woof!!");
    }
    */
    
}