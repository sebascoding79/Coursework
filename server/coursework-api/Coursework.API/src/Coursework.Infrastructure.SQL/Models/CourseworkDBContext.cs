using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Coursework.Core.Models;

namespace Coursework.Infrastructure.SQL.Models;

public class CourseworkDBContext : DbContext
{
    public CourseworkDBContext(DbContextOptions<CourseworkDBContext> options)
        : base(options)
    {
    }

    // Now we need to add the tables we want to have, we can start with the grade table
    // Using a getter/setter is also ok
    public DbSet<Course> Courses => Set<Course>();

}