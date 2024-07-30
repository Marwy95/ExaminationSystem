using AutoMapper;
using ExaminationSystem.DTOs.StudentCourse;
using ExaminationSystem.Services.StudentCourses;
using ExaminationSystem.ViewModels.StudentCourse;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentCourseController : ControllerBase
    {
        IStudentCourseService _studentCourseService;
        IMapper _mapper;
        public StudentCourseController(IStudentCourseService studentCourseService,IMapper mapper) 
        { 
        _studentCourseService = studentCourseService;
        
        }
        [HttpPost]
        public void EnrollStudent(StudentCourseViewModel studentCourseViewModel)
        {
            var studentCourse = _mapper.Map<StudentCourseDTO>(studentCourseViewModel);
            _studentCourseService.Add(studentCourse);
        }

    }
}
