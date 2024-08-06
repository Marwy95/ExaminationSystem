using ExaminationSystem.Models;

namespace ExaminationSystem.DTOs.Course
{
    public class CourseDTO
    {
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public int NumberOfExams { get; set; }
        public int InstructorID { get; set; }
        public HashSet<string> StudentNames{ get; set; }
    }
}
