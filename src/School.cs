namespace src;

public class School
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string PrincipalName { get; set; }
    public int EstablishedYear { get; set; }
    public string SchoolType { get; set; }
    public int NumberOfStudents { get; set; }
    public int NumberOfTeachers { get; set; }
    public double SchoolRating { get; set; }
    public string SchoolMotto { get; set; }
    public bool IsPublicSchool { get; set; }
    public bool UniformRequired { get; set; }
    public DateTime SchoolStartDate { get; set; }
    public DateTime SchoolEndDate { get; set; }
    public DateTime WinterBreakStartDate { get; set; }
    public DateTime WinterBreakEndDate { get; set; }
    public void AddNewStudent()
    {
        NumberOfStudents++;
        Console.WriteLine("A new student has been added.");
    }
    public bool IsWinterBreakActive(DateTime currentDate)
    {
        return currentDate >= WinterBreakStartDate && currentDate <= WinterBreakEndDate;
    }

}


