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
    private readonly ICourseService courseService;

    public CoursesController(ILogger<CoursesController> logger, ICourseService courseService){
        this.logger = logger;
        this.courseService = courseService;
    }
    
    // Get Method to support grabbing a course by ID {id:int} is a template so it takes an int
    // called id and the "id" is part of that route
    // Request URL https://localhost:5001/v1/Grade/1
    // The route will have the id parameter
    [HttpGet("{id:int}")]
    public IActionResult Get([FromRoute] int id)
    {
        this.logger.LogInformation($"Retrieving the course wih id: {id}");

        return courseService
            .FindOneById(id)
            .ToActionResult();
    }

    [HttpGet("")]
    public IActionResult GetCourses()
    {
        this.logger.LogInformation("Retrieves a list of courses");

        return courseService
            .GetAll()
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