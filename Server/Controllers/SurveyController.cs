using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SurveryController : ControllerBase
{
    private static ConcurrentBag<Survey> surveys = new ConcurrentBag<Survey> {
        new Survey {
            Id = Guid.Parse("b00c58c0-df00-49ac-ae85-0a135f75e01b"),
            Title = "Are you excited about .Net 5.0?",
            ExpiresAt = DateTime.Now.AddMinutes(10),
            Options = new List<string>{ "Yes", "Nope", "meh"},
            Answers = new List<SurveyAnswer>{
                new SurveyAnswer { Option = "Yes"},
                new SurveyAnswer { Option = "Yes"},
                new SurveyAnswer { Option = "Yes"},
                new SurveyAnswer { Option = "Nope"},
                new SurveyAnswer { Option = "Meh"}
            }
        }
    };

    [HttpGet]
    public IEnumerable<SurveySummary> GetSurveys()
    {
        return surveys.Select(s => s.ToSummary());
    }

    [HttpGet("{id:Guid}")]
    public ActionResult GetSurvey(Guid id)
    {
        var survey = surveys.FirstOrDefault(s => s.Id == id);
        if (survey is null) return NotFound();
        return new JsonResult(survey);
    }s
}