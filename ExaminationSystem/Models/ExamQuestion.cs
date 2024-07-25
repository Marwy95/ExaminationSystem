namespace ExaminationSystem.Models
{
    public class ExamQuestion
    {
        public int QuizID { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
        public Exam Exam { get; set; }


    }
}
