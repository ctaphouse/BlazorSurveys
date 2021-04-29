using System;
using System.Collections.Generic;

public record Survey
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Title { get; init; }
    public DateTime ExpiresAt { get; init; }
    public List<string> Options { get; init; } = new List<string>();
    public List<SurveyAnswer> Answers { get; init; } = new List<SurveyAnswer>();

    public SurveySummary ToSummary() => new SurveySummary
    {
        Id = this.Id,
        Title = this.Title,
        Options = this.Options,
        ExpiresAt = this.ExpiresAt
    }
}
