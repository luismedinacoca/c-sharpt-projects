namespace _04_DataType_Operations;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();

        var age = 23;
        Console.WriteLine("age: " + age);
        Console.WriteLine("age++");
        age++; // age = age + 1
        Console.WriteLine("age: " + age);
        Console.WriteLine("age--");
        age--; // age -= 1
        Console.WriteLine("age: " + age);

        // time elapse: 27min
    }
}