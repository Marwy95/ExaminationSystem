namespace ExaminationSystem.Models
{
    public class Instructor :User
    {
        public HashSet<Exam> Quizzes { get; set; }
        public HashSet<Course> Courses { get; set; }
    }
}
