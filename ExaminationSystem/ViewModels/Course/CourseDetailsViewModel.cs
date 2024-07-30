using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Course
{
    public class CourseDetailsViewModel

    {
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public int NumberOfExams { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
