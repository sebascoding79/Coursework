using Microsoft.EntityFrameworkCore;

namespace Coursework;

public class PracticeModel1
{
    public int? Id { get; set; }
    public string Description { get; set; }
}

public class PracticeModel2
{
    public int? Id { get; set; }
    public string Description { get; set;}
}

// The classes below become entities when they are attached 
// an dbset (called an entity set) and become properties of a dbcontext

// A db set is basically a table made of rows where each row
// is a model called an entity