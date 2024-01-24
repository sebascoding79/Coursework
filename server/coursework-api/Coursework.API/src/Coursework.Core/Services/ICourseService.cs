using Coursework.Core.Models;
using Coursework.SharedKernel.Models;

namespace Coursework.Core.Services;

public interface ICourseService
{
    Result<Course> FindOneById(int id);

    Result<ICollection<Course>> GetAll();

    Result AddOne(Course course);

    Result UpdateOne(Course course);
}

