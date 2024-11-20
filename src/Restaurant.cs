namespace src;

public class Restaurant
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public bool WiFiAvailable { get; set; }
    public bool IsDeliveryAvailable { get; set; }
    public bool IsTakeoutAvailable { get; set; }
    public bool ParkingAvailable { get; set; }
    public int Rating { get; set; }
    public bool IsOpen { get; set; }
    public int SeatingCapacity { get; set; }
    public DateTime OpeningHours { get; set; }
    public DateTime ClosingHours { get; set; }
    public List<string> Cuisines { get; set; }
    public void TimeUntilClosing()
    {
        if (IsOpen is true)
        {
            var currentTime = DateTime.Now;
            if (ClosingHours >= currentTime)
            {
                TimeSpan timeLeft = ClosingHours - currentTime;
                Console.WriteLine($"Restoran yopilishiga " +
                    $"{timeLeft.Hours}:{timeLeft.Minutes}:{timeLeft.Seconds} vaqt qoldi");
            }
            else
            {
                Console.WriteLine("Restoran allaqachon yopilgan");
            }
        }
    }
    public bool ReserveTable(string customerName, DateTime reservationTime, int numberOfGuests)
    {
        if (reservationTime < OpeningHours || reservationTime >= ClosingHours ||
            numberOfGuests > SeatingCapacity)
        {
            return false;
        }

        return true;
    }
}
