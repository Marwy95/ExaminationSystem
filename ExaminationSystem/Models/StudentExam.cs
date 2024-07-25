namespace ExaminationSystem.Models
{
    public class StudentExam : BaseModel
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }

    }
}
