namespace src;

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public bool IsDomestic { get; set; }
    public int Weight { get; set; }
    public double Height { get; set; }
    public string Color { get; set; }
    public string SizeCategory { get; set; }
    public string FurType { get; set; }
    public string DietType { get; set; }
    public bool IsNocturnal { get; set; }
    public bool IsEndangered { get; set; }
    public void DangerStatus()
    {
        if (IsEndangered is true)
        {
            Console.WriteLine($"{Name} is an endangered species");
        }
        else
        {
            Console.WriteLine($"{Name} is not endangered");
        }
    }
    public string GetAnimalSound()
    {
        if (Species == "Felis catus")
        {
            return "Meow";
        }
        else if (Species == "Panthera tigris altaica")
        {
            return "Roar";
        }
        else if (Species == "Loxodonta africana")
        {
            return "Trumpet";
        }
        else
        {
            return "Unknown sound";
        }
    }
}
