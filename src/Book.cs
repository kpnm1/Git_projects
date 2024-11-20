namespace src;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Publisher { get; set; }
    public int PublicationYear { get; set; }
    public string Genre { get; set; }
    public string Language { get; set; }
    public int PageCount { get; set; }
    public string CoverType { get; set; }
    public string Edition { get; set; }
    public string Summary { get; set; }
    public double Rating { get; set; }
    public double Price { get; set; }
    public bool DigitalVersionAvailable { get; set; }
    public string SeriesName { get; set; }
    public int NumberInSeries { get; set; }
    public int GetBookAge()
    {
        var response = DateTime.Now.Year - PublicationYear;

        return response;
    }
    public void DisplayBookInfo()
    {
        var result = $"Title: {Title}, Author: {Author}, Genre: {Genre}, " +
            $"Rating: {Rating}, Publication year: {PublicationYear}, Price: {Price}";
        Console.WriteLine(result);
    }
}
