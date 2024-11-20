namespace src;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public int DurationInMinutes { get; set; }
    public double Rating { get; set; }
    public List<string> Cast { get; set; }
    public string Language { get; set; }
    public string Country { get; set; }
    public string PlotSummary { get; set; }
    public double Budget { get; set; }
    public List<string> ProductionCompanies { get; set; }
    public List<string> Awards { get; set; }
    public string PosterUrl { get; set; }
    public string TrailerUrl { get; set; }
    public bool IsAvailableForStreaming { get; set; }
    public int GetMovieAge()
    {
        var age = DateTime.Now.Year - ReleaseDate.Year;
        if (DateTime.Now.DayOfYear < ReleaseDate.DayOfYear)
        {
            age--;
        }
        return age;
    }
    public string GetMovieInfo()
    {
        return $"{Title} ({ReleaseDate.Year}) - Directed by {Director}\n" +
               $"Genre: {Genre}\n" +
               $"Rating: {Rating}/10\n" +
               $"Plot: {PlotSummary}";
    }
}
