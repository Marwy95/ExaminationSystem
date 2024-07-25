namespace ExaminationSystem.Models
{
    public class Exam :BaseModel
    {

        public string Type { get; set; } // Quiz-Final
        public int Number { get; set; }
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public HashSet<ExamQuestion> ExamQuestions { get; set; }
    }
}
