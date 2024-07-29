namespace _01_DataType_Numbers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("");
        //variable declaration:
        var x = 10;
        var y = 11;
        var z = 12;

        int a = 10,
            b = 11,
            c = 12;

        int m = 10, n = 11, p = 12;

        Console.WriteLine(" ");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello Hello World");
        Console.WriteLine("");

        //Integer:
        int age;
        age = 23;
        Console.WriteLine("age is: " + age);
        Console.WriteLine("");

        //Long integer:
        var bigNumber = 9000000000000L;
        Console.WriteLine("bigNumber: " + bigNumber);
        Console.WriteLine("");

        //int: MaxValue & MinValue
        Console.WriteLine("Int MaxValue: " + int.MaxValue);
        Console.WriteLine("Int MinValue: " + int.MinValue);
        Console.WriteLine("");

        //long: MaxValue & MinValue
        Console.WriteLine("Long MaxValue: " + long.MaxValue);
        Console.WriteLine("Long MinValue: " + long.MinValue);
        Console.WriteLine("");

        //decimal numbers:
        var negativeNumber = -55.2D;
        Console.WriteLine("negative number (-55.2D): " + negativeNumber);
        Console.WriteLine("double MaxValue: " + double.MaxValue);
        Console.WriteLine("double MinValue: " + double.MinValue);
        Console.WriteLine("");

        //float:
        var precision = 5.000001F;
        Console.WriteLine("precision: " + precision);
        Console.WriteLine("float MaxValue: " + float.MaxValue);
        Console.WriteLine("float MinValue: " + float.MinValue);
        Console.WriteLine("");

        //Money
        var money = 14.99M;
        Console.WriteLine("money: " + money);
        Console.WriteLine("decimal MaxValue: " + decimal.MaxValue);
        Console.WriteLine("decimal MinValue: " + decimal.MinValue);
        Console.WriteLine("");
    }
}