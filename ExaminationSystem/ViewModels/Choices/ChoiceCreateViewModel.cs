namespace ExaminationSystem.ViewModels.Choices;

public class ChoiceCreateViewModel
{
    public int ID { get; set; }
    public string Text { get; set; }
    public int QuestionID { get; set; }
    public bool IsRight { get; set; }
}