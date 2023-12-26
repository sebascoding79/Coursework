using Coursework.Core.Models;

namespace Coursework.Core.Repositories;

public interface IGradesRepository
{
    public Grade FindOne(int id);
}