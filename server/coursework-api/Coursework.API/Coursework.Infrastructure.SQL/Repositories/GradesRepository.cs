using Coursework.Core.Repositories;
using Coursework.Core.Models;
using Coursework.Infrastructure.SQL.Models;
using Coursework.SharedKernel.Models;
using static Coursework.SharedKernel.Models.ResultMapper;

namespace Coursework.Core.Repositories;

public class GradesRepository : IGradesRepository
{
    private readonly CourseworkDBContext _courseworkDbContext;

    public GradesRepository(CourseworkDBContext context)
    {
        _courseworkDbContext = context;
    }
    public Result<Grade> FindOne(int id)
    {
        var grade = _courseworkDbContext.Grades.FirstOrDefault(grade => grade.Id == id);
        return grade is null
            ? Error.NotFound
            : new Result<Grade>(Value: grade);
    }

    public Result AddLetterGrade(string letterGrade)
    {
        var grade = new Grade()
        {
            Letter = letterGrade
        };
        
        _courseworkDbContext.Add(grade);
        _courseworkDbContext.SaveChanges();

        return Ok();
    }
}