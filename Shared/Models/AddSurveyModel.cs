using System.Collections.Generic;

public class AddSurveyModel
{
    public string Title { get; set; }
    public int? Minutes { get; set; }
    public List<OptionCreateModel> Options { get; init; } = new List<OptionCreateModel>();
}