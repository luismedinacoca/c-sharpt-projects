namespace _17_Access_Modifiers;

public class VideoGame
{
    private string id;
    public string name;
    public string publisher;
    public string rating;

    internal VideoGame()
    {
    }

    internal VideoGame(string Name, string Publisher, string Rating)
    {
        name = Name;
        publisher = Publisher;
        rating = Rating;
        
        //Generate unique ID for each new object
        GenerateNewID();
    }

    private void GenerateNewID()
    {
        id = Guid.NewGuid().ToString();
        Console.WriteLine("id: {0}", id); 
    }

    //Properties:
    // public void UpdateName(string Name)
    // {
    //     //Make syre video game name has AT LEAST 2 letters:
    //     bool canUpdateName = !(Name.Length <= 1);
    //     
    //     // any other validation here
    //     
    //     //Then finally update the name:
    //     if (canUpdateName) name = Name;
    // }
    
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            //Make sure video game name has AT LEAST 2 letters:
            bool canUpdateName = !(value.Length <= 1);
        
            // any other validation here
        
            //Then finally update the name:
            if (canUpdateName) name = Name;
        }
    }

    public string Publisher
    {
        get { return publisher; }
    }
}