namespace Coursework.Core.Models;

public class Course : Aggregate<int>
{
    public string Cid { get; set; } = string.Empty;
    public string Cname { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Semester { get; set; } = string.Empty;
    public string Grade { get; set; } = string.Empty;
}