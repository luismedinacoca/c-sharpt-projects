namespace _23_Abstract_classes_and_abstract_methods;

public abstract class Animal
{
    private string name;
    private int age;
    
    public abstract void SayName();

    public virtual void SayAge()
    {
        Console.WriteLine("👉🏽  I am " + Age + " years old!");
    }

    public abstract void MakeNoise();
    // {
    //     Console.WriteLine("* 👉🏽 Makes random animal noises *");
    // }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value;  }
    }
}