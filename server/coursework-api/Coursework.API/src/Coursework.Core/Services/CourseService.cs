using Coursework.Core.Models;
using Coursework.Core.Repositories;
using Coursework.SharedKernel.Models;

namespace Coursework.Core.Services;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseService(ICourseRepository _courseRepository)
    {
        this._courseRepository = _courseRepository;
    }

    public Result<Course> FindOneById(int id)
    {
        return _courseRepository.FindOne(id);
    }

    public Result<ICollection<Course>> GetAll()
    {
        return _courseRepository.GetAll();
    }

    public Result AddOne(Course course)
    {
        return _courseRepository.AddCourse(course);
    }

    public Result UpdateOne(Course course)
    {
        return _courseRepository.UpdateCourse(course);
    }
}