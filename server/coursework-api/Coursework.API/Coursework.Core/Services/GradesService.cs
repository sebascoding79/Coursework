using Coursework.Core.Models;
using Coursework.Core.Repositories;
using Coursework.SharedKernel.Models;

namespace Coursework.Core.Services;

public class GradesService
{
    private readonly IGradesRepository gradesRepository;

    public GradesService(IGradesRepository gradesRepository)
    {
        this.gradesRepository = gradesRepository;
    }
    public Result<Grade> FindOne(int id)
    {
        return gradesRepository.FindOne(id);
    }
    
}