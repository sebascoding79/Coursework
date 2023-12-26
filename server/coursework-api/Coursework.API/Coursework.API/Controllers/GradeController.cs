using Coursework.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Coursework.Infrastructure.SQL.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursework.API.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class GradeController : ControllerBase
{
    private readonly ILogger<GradeController> _logger;
    private readonly CourseworkDBContext _courseworkDbContext;

    public GradeController(ILogger<GradeController> logger, CourseworkDBContext dbContext)
    {
        _logger = logger;
        _courseworkDbContext = dbContext;
    }
    
    // Get Method to support grabbing a grade by ID {id:int} is a template so it takes an int
    // called id and the "id" is part of that route's name
    [HttpGet("{id:int}")]
    public IActionResult Get(
        [FromRoute] int id)
    {
        var gradesTable = _courseworkDbContext.Grade;
        var grade = gradesTable.FirstOrDefault(grade => grade.Id == id);

        return Ok(grade ?? new Grade() { Id = 0, grade = "OOPS" });
    }
}