using Coursework.Core.Models;
using Coursework.SharedKernel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Core.Services
{
    public interface IGradesService
    {
        Result<Grade> FindOne(int id);
        Result AddLetterGrade(string letter);
    }
}
