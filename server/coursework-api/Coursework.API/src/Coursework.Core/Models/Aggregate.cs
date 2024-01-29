namespace Coursework.Core.Models;

public class Aggregate<T> where T : struct
{
    public T? Id { get; set; }
}