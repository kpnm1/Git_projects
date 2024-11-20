namespace src;

public class Phone
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string OperatingSystem { get; set; }
    public int ReleaseYear { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public int StorageCapacity { get; set; }
    public int RAM { get; set; }
    public int BatteryCapacity { get; set; }
    public double ScreenSize { get; set; }
    public int CameraResolution { get; set; }
    public int FrontCameraResolution { get; set; }
    public bool Is5GEnabled { get; set; }
    public string WaterResistanceRating { get; set; }
    public bool DualSIM { get; set; }
    public bool FaceRecognition { get; set; }
    public bool FingerprintScanner { get; set; }
    public bool IsWirelessChargingSupported { get; set; }
    public double Weight { get; set; }
    public DateTime WarrantyExpirationDate { get; set; }
    public string CheckBatteryLife(int currentBatteryPercentage)
    {
        if (currentBatteryPercentage >= 80)
        {
            return "Battery is high";
        }
        else if (currentBatteryPercentage >= 40)
        {
            return "Battery is medium";
        }
        else if (currentBatteryPercentage > 0)
        {
            return "Battery is low, please charge soon";
        }
        else
        {
            return "Battery is empty, phone is off";
        }
    }
    public bool IsUnderWarranty(DateTime currentDate)
    {
        return currentDate <= WarrantyExpirationDate;
    }
}


