using Coursework.Core.Models;
using Coursework.Infrastructure.SQL.Models;

namespace Coursework.Core.Repositories;

public class GradesRepository
{
    private readonly CourseworkDBContext _courseworkDbContext;

    public GradesRepository(CourseworkDBContext context)
    {
        _courseworkDbContext = context;
    }
    public Grade FindOne(int id)
    {
        var grade = _courseworkDbContext.Grade.FirstOrDefault(grade => grade.Id == id);
        return grade ?? new Grade() { Id = 0, grade = "OOPS" };
    }
}