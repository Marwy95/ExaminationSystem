using ExaminationSystem.DTOs.Course;

namespace ExaminationSystem.Services.Courses
{
    public interface ICourseService
    {
        void Add(CourseCreateDTO courseDTO);
        IEnumerable<CourseDTO> Get(int id);
        bool Delete(int id);
        bool Update(CourseUpdateDTO courseDTO,int id,int instructorID);
    }
}
