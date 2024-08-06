
using ExaminationSystem.ViewModels.Choices;

namespace ExaminationSystem.ViewModels.Question
{
    public class QuestionCreateViewModel
    {
        
        public string Text { get; set; }
        public string Level { get; set; } //Simple-Medium-Hard
        public HashSet<ChoiceCreateViewModel> choices { get; set; }
    }
}
