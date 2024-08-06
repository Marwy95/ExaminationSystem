namespace ExaminationSystem.Models
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public string Level { get; set; } //Simple-Medium-Hard
        public HashSet<ExamQuestion> ExamQuestions { get; set; }
        public HashSet<Choice> choices { get; set; }
        public Instructor Instructor { get; set; }
        public int InstructorID { get; set; }

        
    }
}
