using ExaminationSystem.DTOs.Choices;

namespace ExaminationSystem.DTOs.Question
{
    public class QuestionDTO
    {
        public string Text { get; set; }
        public string Level { get; set; } //Simple-Medium-Hard
        public HashSet<ChoiceDTO> choices { get; set; }
    }
}
