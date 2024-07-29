namespace _06_Try_Parse_Function;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.Write("Enter a number: ");
        string numInput = Console.ReadLine();
        int num = 0;
        Console.WriteLine(num);
        bool success = int.TryParse(numInput, out num);
        if (success)
        {
            Console.WriteLine("number: {0}", num);
        }
        else
        {
            Console.WriteLine("Failed to Convert!!!");
        }
        */
        
        bool success = true;
        while (success)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            
            if(int.TryParse(numInput, out int num)){
                Console.WriteLine("the number is {0}", num);
                success = false;
            }
            else
            {
                Console.WriteLine("Failed to Convert!");
            }
        }
        Console.ReadLine();
    }
}