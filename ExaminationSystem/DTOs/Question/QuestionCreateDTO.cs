using ExaminationSystem.DTOs.Choices;

namespace ExaminationSystem.DTOs.Question
{
    public class QuestionCreateDTO
    {
        
        public string Text { get; set; }
        public string Level { get; set; } //Simple-Medium-Hard
        public HashSet<ChoiceCreateDTO> choices { get; set; }
    }
}
