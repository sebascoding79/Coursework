using Coursework.Core.Models;
using Coursework.SharedKernel.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursework.Core.Repositories;

public interface ICourseRepository
{
    public Result<Course> FindOne(int id);

    public Result<ICollection<Course>> GetAll();
    public Result AddCourse(Course course);
    public Result UpdateCourse(Course course);
}