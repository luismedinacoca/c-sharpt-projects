namespace _12_Multidimensional_arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("num01 - 1D:");
        // 1, 2, 3
        //Define some cool numbers:
        int[] num01 = new int[] { 1, 2, 3 };
        Console.WriteLine("num01[0]: {0}", num01[0]);
        Console.WriteLine("num01[1]: {0}", num01[1]);
        Console.WriteLine("num01[2]: {0}", num01[2]);
        Console.WriteLine("");
        
        Console.WriteLine("num02 - 2D:");
        // 1, 2, 3
        // 4, 5, 6
        // 7, 8, 9
        //Define some cool numbers:
        int[,] num02 = new int[,] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        Console.WriteLine("num02[0,0]: {0}", num02[0, 0]);
        Console.WriteLine("num02[0,1]: {0}", num02[0, 1]);
        Console.WriteLine("num02[0,2]: {0}", num02[0, 2]);
        Console.WriteLine("num02[1,0]: {0}", num02[1, 0]);
        Console.WriteLine("num02[1,1]: {0}", num02[1, 1]);
        Console.WriteLine("num02[1,2]: {0}", num02[1, 2]);
        Console.WriteLine("num02[2,0]: {0}", num02[2, 0]);
        Console.WriteLine("num02[2,1]: {0}", num02[2, 1]);
        Console.WriteLine("num02[2,2]: {0}", num02[2, 2]);
        Console.WriteLine("");
        
        Console.WriteLine("num03 - 3D:");
        // 1, 2     // 5, 6
        // 3, 4     // 7, 8
        
        //Define some cool numbers:
        int[,,] num03 = new int[,,] { {{1, 2}, {3, 4}}, {{5, 6}, {7, 8}}};
        Console.WriteLine("num03[0, 0, 0]: {0}", num03[0, 0, 0]);
        Console.WriteLine("num03[0, 0, 1]: {0}", num03[0, 0, 1]);
        Console.WriteLine("num03[0, 1, 0]: {0}", num03[0, 1, 0]);
        Console.WriteLine("num03[0, 1, 1]: {0}", num03[0, 1, 1]);
        Console.WriteLine("num03[1, 0, 0]: {0}", num03[1, 0, 0]);
        Console.WriteLine("num03[1, 0, 1]: {0}", num03[1, 0, 1]);
        Console.WriteLine("num03[1, 1, 0]: {0}", num03[1, 1, 0]);
        Console.WriteLine("num03[1, 1, 1]: {0}", num03[1, 1, 1]);
    }
}