namespace _24_the_THIS_keyword;

public class Dog : Animal
{
    public void MakeNoise()
    {
        Console.WriteLine("Woof woof!!");

        Helper helper = new Helper();
        helper.MakeMoreNoise(this);
    }
}