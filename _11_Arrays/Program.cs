namespace _11_Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 2, 4, 6, 8, 10 };
        Console.WriteLine(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }
    }
}