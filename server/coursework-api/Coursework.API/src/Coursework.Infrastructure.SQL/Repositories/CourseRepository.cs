using Coursework.Core.Models;
using Coursework.Core.Repositories;
using Coursework.Infrastructure.SQL.Models;
using Coursework.SharedKernel.Models;
using static Coursework.SharedKernel.Models.ResultMapper;

namespace Coursework.Infrastructure.SQL.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly CourseworkDBContext _courseworkDbContext;

    public CourseRepository(CourseworkDBContext courseworkDbContext)
    {
        _courseworkDbContext = courseworkDbContext;
    }
    
    public Result<Course> FindOne(int id)
    {
        var course = _courseworkDbContext
            .Courses
            .FirstOrDefault(course => course.Id == id);
        return course is null
            ? Error.NotFound
            : new Result<Course>(Value: course);
    }

    public Result AddCourse(Course course)
    {
        _courseworkDbContext
            .Courses
            .Add(course);
        _courseworkDbContext.SaveChanges();
        return Ok();
    }

    public Result UpdateCourse(Course course)
    {
        _courseworkDbContext
            .Courses
            .Update(course);
        _courseworkDbContext.SaveChanges();
        return Ok();
    }
}