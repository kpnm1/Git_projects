namespace src;

public class Game
{
    public string Title { get; set; }
    public string Developer { get; set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<string> Platform { get; set; }
    public string AgeRating { get; set; }
    public double Price { get; set; }
    public bool MultiplayerSupport { get; set; }
    public bool SinglePlayerSupport { get; set; }
    public string MinimumRequirements { get; set; }
    public string RecommendedRequirements { get; set; }
    public double Rating { get; set; }
    public List<string> LanguageSupport { get; set; }
    public double DownloadSize { get; set; }
    public int NumberOfPlayers { get; set; }
    public string GameMode { get; set; }
    public bool IsOnSale(double originalPrice)
    {
        if (Price < originalPrice)
        {
            Console.WriteLine($"{Title} is on sale! Current price: ${Price} " +
                $"(Original price: ${originalPrice}).");
            return true;
        }
        else
        {
            Console.WriteLine($"{Title} is not on sale. Current price: ${Price}.");
            return false;
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Game Information:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Release Date: {ReleaseDate:MMMM dd, yyyy}");
        Console.WriteLine($"Multiplayer: {(MultiplayerSupport ? "Yes" : "No")}");
        Console.WriteLine($"Minimum Requirements: {MinimumRequirements}");
        Console.WriteLine($"Recommended Requirements: {RecommendedRequirements}");
        Console.WriteLine($"Rating: {Rating}/5");
    }

}