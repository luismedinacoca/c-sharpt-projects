namespace _12_Multidimensional_arrays_game;

class Program
{
    static void Main(string[] args)
    {
        // C R B Q K B R C
        // P P P P P P P P
        // 0 0 0 0 0 0 0 0
        // 0 0 0 0 0 0 0 0
        // 0 0 0 0 0 0 0 0
        // 0 0 0 0 0 0 0 0
        // P P P P P P P P
        // C R B Q K B R C

        char[,] chess = new char[,]
        {
            { 'C', 'R', 'B', 'Q', 'K', 'B', 'R', 'C' },
            { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
            { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
            { 'C', 'R', 'B', 'Q', 'K', 'B', 'R', 'C' }
        };

        for (int y = 0; y < chess.GetLength(0); y++)
        {
            for (int x = 0; x < chess.GetLength(1); x++)
            {
                if (chess[x, y] == 'Q')
                {
                    Console.WriteLine("Queen found at this location: " + x + ", " + y);
                }
            }
        }
    }
}