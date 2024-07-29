namespace _10_Exception_Handling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ************* Welcome to the number divider! ************* ");

        try
        {
            Console.WriteLine("Enter your first number:");
            int num01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num02 = Convert.ToInt32(Console.ReadLine());

            int result = num01 / num02;
            Console.WriteLine("The result is " + result);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Learn to read properly");
            throw;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Hey Buddy! you cannot divided by zero!!");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            Console.Write("Thank you for using our program!");
        }
    }
}