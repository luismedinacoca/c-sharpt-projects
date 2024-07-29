namespace _17_Access_Modifiers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        
        // Ratings: E, 10+, Teen, Mature 17+, Adults Only 18+, Rating Pending 
        VideoGame game1 = new VideoGame("World of Warcraft", "Blizzard", "Teen");
        VideoGame game2 = new VideoGame("League of Legends", "Riot Games", "Teen");
        VideoGame game3 = new VideoGame("Grand Theft Auto V", "Rockstar Games", "Adults Only 18");
        VideoGame game4 = new VideoGame("Minecraft", "Mojang Studios", "10+");

        //game1.Publisher = "Riot Games";
        Console.WriteLine(">> Game1: {0}", game1);
        game1.Name = "g";
        /*
         when "internal string id" and "internal void GenerateNewId()"
         or
         when "protected internal string id" and "protected internal void GenerateNewId()"
        game1.id = "ilhsdwhlo.";
        game1.GenerateNewID();
        */
        
        Console.WriteLine(">> Game1 Name: {0}", game1.Name);
        //game1.Publisher = "reuyvjlsndvf";
    }
}