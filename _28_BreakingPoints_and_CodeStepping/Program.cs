namespace _28_BreakingPoints_and_CodeStepping;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a day of the week: ");
        string input = Console.ReadLine();
        OutputMessage(input);
    }

    private static void OutputMessage(string input)
    {
        switch (input)
        {
            case "monday":
                Console.WriteLine("I dislike Monday!!");
                break;
            case "tuesday":
                Console.WriteLine("Tuesday Tuesday Tuesday!");
                break;
            case "wednesdaY":
                Console.WriteLine("YWednesday are meh!");
                break;
            case "thursday":
                Console.WriteLine("Thursdays are nice because I only work half a day at work!");
                break;
            case "friday":
                Console.WriteLine("It's weekend tomorrow!");
                break;
            case "saturday":
                Console.WriteLine("Saturday is great because I don't have to work!");
                break;
            case "sunday":
                Console.WriteLine("I'm not looking forward to work again on onday!!");
                break;
            default:
                Console.WriteLine("You entered an invalid day!");
                break;
        }
        Console.WriteLine("");
    }
}