using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FakeItEasy;
using Coursework.API.Controllers;
using Coursework.Core.Services;
using Coursework.Core.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Coursework.SharedKernel.Models;
using Coursework.Infrastructure.SQL.Models;
using static Coursework.SharedKernel.Models.ResultMapper;

namespace Coursework.API.Tests
{
    public class GradesControllerTests
    {
        private readonly ILogger<GradesController> logger;
        private readonly IGradesService gradesService;
        private readonly GradesController sut;

        public GradesControllerTests()
        {
            this.logger = A.Fake<ILogger<GradesController>>();  
            this.gradesService = A.Fake<IGradesService>();
            this.sut = new GradesController(this.logger, this.gradesService);
        }

        [Fact]
        public void GetId_ShouldReturnOk()
        {
            // Arrange
            var grade = new Grade
            {
                Id = 1,
                Letter = "A"
            };

            var result = Ok(grade);

            var objectResult = GetObjectResult(result.Value);

            // Here you are setting up the call that is about to happen
            // and return an expected result
            A.CallTo(() =>
                this.gradesService
                    .FindOne(
                        A<int>.Ignored))
                .Returns(result);

            // Act
            var actionResult = this.sut
                .GetId(1);

            // actionResult is an IActionResult that has a value attribute
            // Assert
            actionResult.Should().BeEquivalentTo(objectResult);
        }

        private ObjectResult GetObjectResult(object? value) =>
            new(value)
            {
                Value = value,
                StatusCode = 200
            };
    }
}
