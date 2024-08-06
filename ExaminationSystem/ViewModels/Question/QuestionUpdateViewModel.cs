using ExaminationSystem.ViewModels.Choices;

namespace ExaminationSystem.ViewModels.Question
{
    public class QuestionUpdateViewModel
    {
        public int ID { get; set; }      
        public string Text { get; set; }
        public string Level { get; set; } 
        public HashSet<ChoiceUpdateViewModel> choices { get; set; }
    }
}
