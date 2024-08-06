using ExaminationSystem.DTOs.Choices;

namespace ExaminationSystem.DTOs.Question
{
    public class QuestionUpdateDTO
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Level { get; set; }
        public HashSet<ChoiceUpdateDTO> choices { get; set; }
    }
}
