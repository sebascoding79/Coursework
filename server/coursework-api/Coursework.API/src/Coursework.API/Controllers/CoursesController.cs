using Coursework.Core.Models;
using Coursework.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Coursework.SharedKernel.Models;

namespace Coursework.API.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly ILogger<CoursesController> logger;
    private readonly CourseService courseService;

    public CoursesController(ILogger<CoursesController> logger, CourseService courseService){
        this.logger = logger;
        this.courseService = courseService;
    }
    
    // Get Method to support grabbing a grade by ID {id:int} is a template so it takes an int
    // called id and the "id" is part of that route's name
    // Request URL https://localhost:5001/v1/Grade/1
    // The route will have the id parameter
    [HttpGet("{id:int}")]
    public IActionResult Get([FromRoute] int id)
    {
        return courseService
            .FindOneById(id)
            .ToActionResult();
    }

    [HttpPost("AddCourse")]
    public IActionResult AddCourse(Course course)
    {
        return courseService
            .AddOne(course)
            .ToActionResult();
    }
}