namespace _24_the_THIS_keyword;

public class Animal
{
    private string name;
    private int age;

    public void AnimalMethod()
    {
        Console.WriteLine("This is an animal method. It does not do much!");
    }

    public void SayName()
    {
        Console.WriteLine("My name is " + Name);
    }

    public void SayAge()
    {
        Console.WriteLine("👉🏽 I am " + Age + " years old!");
    }

    public void MakeNoise()
    {
        Console.WriteLine("* Makes random animal noises *");
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}