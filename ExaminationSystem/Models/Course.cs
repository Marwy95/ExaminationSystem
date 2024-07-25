namespace ExaminationSystem.Models
{
    public class Course
    {
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public HashSet<Exam> Quizzes { get; set; }
        
    }
}
