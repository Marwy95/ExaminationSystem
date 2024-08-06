using ExaminationSystem.DTOs.StudentCourse;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.Services.StudentCourses;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace ExaminationSystem.Mediators.Courses
{
    public class CourseMediator :ICourseMediator
    {
        ICourseService _courseService;
        IStudentCourseService _studentCourseService;
        public CourseMediator(ICourseService courseService,IStudentCourseService studentCourseService)
        {
            _courseService = courseService;
            _studentCourseService = studentCourseService;
        }
        public void EnrollStudentToCourse(StudentCourseDTO studentCourseDTO, int instructorID)
        {
            var course = _courseService.GetById(studentCourseDTO.CourseID);
            if (course != null&& course.InstructorID == instructorID)
            {
                _studentCourseService.Add(studentCourseDTO);
            }
                

        }
    }
}
