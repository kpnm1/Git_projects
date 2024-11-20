namespace src;

public class Planet
{
    public string Name { get; set; }
    public double Radius { get; set; }
    public double Mass { get; set; }
    public double DistanceFromSun { get; set; }
    public double OrbitalPeriod { get; set; }
    public double DayLength { get; set; }
    public string Atmosphere { get; set; }
    public double SurfaceTemperature { get; set; }
    public int MoonsCount { get; set; }
    public bool IsHabitable { get; set; }
    public double Gravity { get; set; }
    public int DiscoveryYear { get; set; }
    public string PlanetType { get; set; }
    public bool HasRings { get; set; }
    public string SurfaceComposition { get; set; }
    public bool IsInHabitableZone()
    {
        const double habitableZoneMin = 0.95; // in AU (Astronomical Units)
        const double habitableZoneMax = 1.37; // in AU (Astronomical Units)

        if (DistanceFromSun >= habitableZoneMin && DistanceFromSun <= habitableZoneMax)
        {
            return true;
        }

        return false;
    }
}