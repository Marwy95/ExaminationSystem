using ExaminationSystem.DTOs.StudentCourse;

namespace ExaminationSystem.Mediators.Courses
{
    public interface ICourseMediator
    {
        void EnrollStudentToCourse(StudentCourseDTO studentCourseDTO, int instructorID);
    }
}
