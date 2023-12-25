using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Coursework;

//That a db context can represent a database holding different tables
//Each table would be a DbSet<entity> table-name
public class PracticeContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost;database=Coursework;User Id=sa;Password=Password01;TrustServerCertificate=true;integrated security=false;");
    }

    public DbSet<PracticeModel1> practice1 { get; set; }
    public DbSet<PracticeModel2> practice2 { get; set; }
}