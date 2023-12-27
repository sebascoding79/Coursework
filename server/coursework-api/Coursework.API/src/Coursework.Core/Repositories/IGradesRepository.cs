using Coursework.Core.Models;
using Coursework.SharedKernel.Models;

namespace Coursework.Core.Repositories;

public interface IGradesRepository
{
    public Result<Grade> FindOne(int id);

    public Result AddLetterGrade(string letterGrade);
}