namespace _05_Debugger;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        var i = 0;
        Console.Write("Please, enter a number: ");
        i = Convert.ToInt32(Console.ReadLine()!);

        var j = 0;
        while (j < i)
        {
            Console.WriteLine(j);
            j++;
        }
    }
}