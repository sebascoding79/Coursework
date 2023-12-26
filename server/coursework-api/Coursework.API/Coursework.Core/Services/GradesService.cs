using Coursework.Core.Models;
using Coursework.Core.Repositories;
using Coursework.Infrastructure.SQL.Models;

namespace Coursework.Core.Services;

public class GradesService
{
    private readonly GradesRepository gradesRepository;

    public GradesService(GradesRepository repository)
    {
        this.gradesRepository = repository;
    }
    public Grade FindOne(int id)
    {
        return gradesRepository.FindOne(id);
    }
}