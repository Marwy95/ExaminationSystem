using AutoMapper;
using ExaminationSystem.DTOs.Student;
using ExaminationSystem.Services.Students;
using ExaminationSystem.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;

        }
        [HttpGet]
        public IEnumerable<StudentViewModel> Get()
        {
            var students = _studentService.Get();
            return _mapper.Map<IEnumerable<StudentViewModel>>(students);
        }

        [HttpPost]
        public void Register(StudentRegisterViewModel studentRegisterViewModel)
        {
            var student = _mapper.Map<StudentRegisterDTO>(studentRegisterViewModel);
            _studentService.Register(student);
        }
        [HttpPost]
        public void Login(StudentLoginViewModel studentLoginViewModel)
        {

            var student = _mapper.Map<StudentLoginDTO>(studentLoginViewModel);
            _studentService.Login(student);
        }


    }
}
