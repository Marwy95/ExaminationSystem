using AutoMapper;
using ExaminationSystem.DTOs.StudentCourse;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.StudentCourses
{
    public class StudentCourseService:IStudentCourseService
    {
        IRepository<StudentCourse> _studentCourseRepo;
        IMapper _mapper;
        public StudentCourseService(IRepository<StudentCourse> studentCourseRepo, IMapper mapper)
        {
           _studentCourseRepo = studentCourseRepo;
            _mapper = mapper;
                
        }
        public void Add(StudentCourseDTO studentCourseDTO)
        {
           
            var studentCourse = _mapper.Map<StudentCourse>(studentCourseDTO);
            _studentCourseRepo.Add(studentCourse);
            _studentCourseRepo.SaveChanges();
        }
    }
}
