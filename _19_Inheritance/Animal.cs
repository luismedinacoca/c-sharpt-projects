namespace _19_Inheritance;

public class Animal
{
    private string name;
    private int age;
    
    public void SayName()
    {
        Console.WriteLine("My name is " + name);
    }

    public void SayAge()
    {
        Console.WriteLine("I am " + age + " years old!" );
    }

    public string Name
    {
        set {  name = value; }
        get {  return name; }
    }

    public int Age
    {
        set { age = value; }
        get { return age; }
    }
}