namespace _26_Interface;

public abstract class Animal
{
    private string name;
    private int age;
    
    // Animal constructor:
    // public Animal(string name, int age)
    // {
    //     this.name = name;
    //     this.age = age;
    // }
    
    // ********* abstract method *********
    public abstract void MakeNoise();

    public void SayName()
    {
        Console.WriteLine("My name is " + Name);
    }

    public void SayAge()
    {
        Console.WriteLine("👉🏽  I am " + Age + " years old!");
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