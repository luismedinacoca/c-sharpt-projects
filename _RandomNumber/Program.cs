namespace _RandomNumber;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int secretNumber = rnd.Next(1, 11); // between 1 and 10
        int numberGuessed = 0;
        Console.WriteLine("Random Num: ", secretNumber);

        do
        {
            Console.Write("Enter a number between 1 & 10: ");
            numberGuessed = Convert.ToInt32(Console.ReadLine());
        } while (secretNumber != numberGuessed);
        
        Console.WriteLine("You guessed it, it was  number {0}", secretNumber);

    }
}