using ExaminationSystem.DTOs.Course;

namespace ExaminationSystem.Services.Courses
{
    public interface ICourseService
    {
        void Add(CourseCreateDTO courseDTO);
        IEnumerable<CourseDTO> Get();
    }
}
