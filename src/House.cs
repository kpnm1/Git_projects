namespace src;

public class House
{
    public string Address { get; set; }
    public int NumberOfRooms { get; set; }
    public int SquareFootage { get; set; }
    public int YearBuilt { get; set; }
    public double Price { get; set; }
    public string OwnerName { get; set; }
    public bool IsForSale { get; set; }
    public bool HasGarage { get; set; }
    public int NumberOfBathrooms { get; set; }
    public bool IsFurnished { get; set; }
    public bool IsPoolAvailable { get; set; }
    public bool HasGarden { get; set; }
    public bool IsLuxuryHome()
    {
        return Price > 1000000 && NumberOfRooms > 5;
    }
    public double CalculatePropertyTax(double taxRate = 0.01)
    {
        return Price * taxRate;
    }
}
