using Coursework.Core.Models;
using Coursework.Core.Repositories;
using Coursework.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Coursework.Infrastructure.SQL.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursework.API.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class GradeController : ControllerBase
{
    private readonly ILogger<GradeController> _logger;
    private readonly GradesService gradesService;
    private readonly CourseworkDBContext _courseworkDbContext;

    public GradeController(ILogger<GradeController> logger, CourseworkDBContext _courseworkDbContext)
    {
        _logger = logger;
        gradesService = new GradesService(new GradesRepository(_courseworkDbContext));
    }
    
    // Get Method to support grabbing a grade by ID {id:int} is a template so it takes an int
    // called id and the "id" is part of that route's name
    [HttpGet("{id:int}")]
    public Grade Get(
        [FromRoute] int id)
    {
        return gradesService.FindOne(id);
    }
}