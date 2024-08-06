using AutoMapper;
using ExaminationSystem.DTOs.StudentCourse;
using ExaminationSystem.Mediators.Courses;
using ExaminationSystem.Services.StudentCourses;
using ExaminationSystem.ViewModels.StudentCourse;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentCourseController : ControllerBase
    {
        ICourseMediator _courseMediator;
        IMapper _mapper;
        public StudentCourseController(ICourseMediator courseMediator, IMapper mapper) 
        {
            _courseMediator = courseMediator;
            _mapper = mapper;
        
        }
        [HttpPost]
        public void EnrollStudent(StudentCourseViewModel studentCourseViewModel,int instructorID)
        {
            var studentCourseDTO = _mapper.Map<StudentCourseDTO>(studentCourseViewModel);
            _courseMediator.EnrollStudentToCourse(studentCourseDTO, instructorID);
        }

    }
}
