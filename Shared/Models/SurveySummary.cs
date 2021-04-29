using System;
using System.Collections.Generic;

public record SurveySummary
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public DateTime ExpiresAt { get; init; }
    public List<string> Options { get; init; }
}