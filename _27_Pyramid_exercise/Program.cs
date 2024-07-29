namespace _27_Pyramid_exercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("******************************************************************");
        Console.WriteLine("************* Welcome to rhe Pyramid Drawing App! ***************");
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("*");
        Console.Write("How high do you want your pyramid to be?: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        DrawPyramid(num);
    }

    private static void DrawPyramid(int size)
    {
        for (int y = 1; y <= size; y++) //it represents the high of the pyramid
        {
            // Hyphen on the left:
            for (int h = 1; h <= (size - y); h++)
            {
                Console.Write("-");
            }
            
            // Draw the pyramid
            for (int p = 1; p <= ((2*y) - 1); p++)
            {
                
                Console.Write("#");
            }
            
            // Hyphen on the right:
            for (int h = 1; h <= (size - y); h++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }
    }
}