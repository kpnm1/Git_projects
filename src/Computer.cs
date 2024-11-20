namespace src;

public class Computer
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Processor { get; set; }
    public int RAM { get; set; } 
    public string Storage { get; set; } 
    public string GraphicsCard { get; set; }
    public string OperatingSystem { get; set; }
    public double ScreenSize { get; set; } 
    public string Resolution { get; set; } 
    public double Weight { get; set; } 
    public double BatteryLife { get; set; } 
    public double Price { get; set; } 
    public bool IsDesktop { get; set; }
    public List<string> Ports { get; set; } 
    public List<string> Connectivity { get; set; } 
    public int WarrantyPeriod { get; set; } 
    public int ReleaseYear { get; set; }
    public string Color { get; set; }
    public string SerialNumber { get; set; }
    public bool IsGamingPC { get; set; }
    public string CoolingSystem { get; set; }
    public void UpgradeRAM(int additionalRAM)
    {
        if (additionalRAM > 0)
        {
            RAM += additionalRAM;
            Console.WriteLine($"RAM has been upgraded. The computer now has {RAM} GB of RAM.");
        }
        else
        {
            Console.WriteLine("Invalid RAM upgrade value. Please specify a positive number.");
        }
    }
    public bool IsUnderWarranty()
    {
        var currentYear = DateTime.Now.Year;
        var warrantyEndYear = ReleaseYear + (WarrantyPeriod / 12);
        return currentYear <= warrantyEndYear;
    }
}