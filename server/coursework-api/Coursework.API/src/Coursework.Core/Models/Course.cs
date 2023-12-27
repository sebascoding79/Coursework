namespace Coursework.Core.Models;

public class Course
{
    public int? Id { get; set; }
    public string CId { get; set; }
    public string CName { get; set; }
    public Grade Grade { get; set; }
    public Semester Semester { get; set; }
}