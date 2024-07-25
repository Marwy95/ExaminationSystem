namespace ExaminationSystem.Models
{
    public class Course : BaseModel
    {
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public HashSet<Exam>? Quizzes { get; set; }
        public HashSet<StudentCourse> StudentCourses { get; set; }

    }
}
