namespace _13_lists;

class Program
{
    static void Main(string[] args)
    {
        //Define some cool numbers
        int[] numbers = new int[] { 4649, 3, 67, 248, 1, 67, 576445, 33, 345, 98, 12, 6543 };
        
        //List<int> list = new List<int>() { 4649, 3, 67, 248, 1, 67, 576445, 33, 345, 98, 12, 6543 };
        List<int> list = new List<int>(numbers);
        
        list.Sort();
        
        //output each number to the screen
        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
        /*
           1
           3
           12
           33
           67
           67
           98
           248
           345
           4649
           6543
           576445
         */
    }
}