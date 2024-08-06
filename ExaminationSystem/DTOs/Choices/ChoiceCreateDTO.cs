namespace ExaminationSystem.DTOs.Choices
{
    public class ChoiceCreateDTO
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public bool IsRight { get; set; }
    }
}
