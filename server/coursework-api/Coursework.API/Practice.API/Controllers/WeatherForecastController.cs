using Coursework;
using Microsoft.AspNetCore.Mvc;

namespace Practice.API.Controllers;

[ApiController]
[Route("[controller]")]
//[Route("[controller]")] -> Name of the class without "Controller"
public class PracticeSwaggerController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PracticeSwaggerController> _logger;

    public PracticeSwaggerController(ILogger<PracticeSwaggerController> logger)
    {
        _logger = logger;
    }
    
    
    [HttpGet(Name = "Ghhh")]
    public PracticeModel2 GetModel2Real()
    {
        var practiceContext = new PracticeContext();
        var practice2set = practiceContext.practice2;
        var row2 = practice2set.FirstOrDefault(row => row.Id == 1);
        if (row2 is null)
        {
            return new PracticeModel2()
            {
                Id = 2,
                Description = "hh"
            };
        }
        return row2;
    }
    

}