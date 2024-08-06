using ExaminationSystem.ViewModels.Choices;

namespace ExaminationSystem.ViewModels.Question
{
    public class QuestionViewModel
    {
        public string Text { get; set; }
        public string Level { get; set; }
        public HashSet<ChoiceViewModel> choices { get; set; }
    }
}
