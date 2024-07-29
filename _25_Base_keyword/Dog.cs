namespace _25_Base_keyword;

internal class Dog : Animal
{
    private string breed;
    
    // Dog constructor:
    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.breed = breed;
    }

    public void Info()
    {
        Console.WriteLine("Name: {0}", base.Name);
        Console.WriteLine("Age: {0}", base.Age);
        Console.WriteLine("Breed: {0}", Breed);
        //Animal.AnimalMethod();
    }

    public void MakeNoise()
    {
        Console.WriteLine("Barking: Woof woof!!");
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }
}