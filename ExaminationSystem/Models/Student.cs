namespace ExaminationSystem.Models
{
    public class Student
    {
        public HashSet<Course> Courses { get; set; }
        public HashSet<Exam> Exams { get; set; }
    }
}
