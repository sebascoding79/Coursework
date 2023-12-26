using Coursework.Core.Models;
using Coursework.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Coursework.Infrastructure.SQL.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursework.API.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class GradeController : ControllerBase
{
    private readonly ILogger<GradeController> logger;
    private readonly GradesService gradesService;

    public GradeController(ILogger<GradeController> logger, GradesService gradesService)
    {
        this.logger = logger;
        this.gradesService = gradesService;
    }
    
    // Get Method to support grabbing a grade by ID {id:int} is a template so it takes an int
    // called id and the "id" is part of that route's name
    [HttpGet("{id:int}")]
    public IActionResult Get(
        [FromRoute] int id)
    {
        return Ok(gradesService.FindOne(id));
    }
}