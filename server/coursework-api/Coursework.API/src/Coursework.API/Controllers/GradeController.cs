using Coursework.Core.Models;
using Coursework.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Coursework.Infrastructure.SQL.Models;
using Coursework.SharedKernel.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Coursework.API.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class GradesController : ControllerBase
{
    private readonly ILogger<GradesController> logger;
    private readonly IGradesService gradesService;

    public GradesController(ILogger<GradesController> logger, IGradesService gradesService)
    {
        this.logger = logger;
        this.gradesService = gradesService;
    }

    // Request URL
    //'https://localhost:5001/grade?id=1'
    // Bind required - forces us to have the parameter in question (not null)
    [HttpGet("{id:int}")]
    public IActionResult GetId([FromRoute] int id)
    {
        return gradesService
            .FindOne(id)
            .ToActionResult();
    }

    [HttpPost("AddGrade")]
    public IActionResult AddGrade(string letterGrade)
    {
        return gradesService
            .AddLetterGrade(letterGrade)
            .ToActionResult();
    }
}