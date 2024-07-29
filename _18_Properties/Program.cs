namespace _18_Properties;

class Program
{
    static void Main(string[] args)
    {
        // Ratings: E, 10+, Teen, Mature 17+, Adults Only 18+, Rating Pending 
        VideoGame game1 = new VideoGame("World of Warcraft", "Blizzard", "Teen");
        VideoGame game2 = new VideoGame("League of Legends", "Riot Games", "Teen");
        VideoGame game3 = new VideoGame("Grand Theft Auto V", "Rockstar Games", "Adults Only 18");
        VideoGame game4 = new VideoGame("Minecraft", "Mojang Studios", "10+");

        // avoid this game1.name  
        Console.WriteLine(game1.Name);
        game1.Name = "g";
        // game1.UpdateName("g");
        Console.WriteLine(game1.Name);
        Console.WriteLine("game1.Name = 'Street Fighter'");
        game1.Name = "Street Fighter";
        Console.WriteLine("game1.Name {0}", game1.Name);
        // game1.Publisher = "Hello World"; //The property '_18_Properties.VideoGame.Publisher' has no setter
    }
}