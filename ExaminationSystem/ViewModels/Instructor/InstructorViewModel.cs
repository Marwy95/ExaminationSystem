using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instructor
{
    public class InstructorViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
        public string Email { get; set; }
        public int  NoOfExams { get; set; }
        public int NoOfCourses { get; set; }

    }
}
