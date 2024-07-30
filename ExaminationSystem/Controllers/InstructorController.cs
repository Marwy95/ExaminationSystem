
using AutoMapper;
using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Services.Instructors;
using ExaminationSystem.ViewModels.Instructor;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InstructorController : ControllerBase
    {
        
        private readonly IInstructorService _instructorService;
        private readonly IMapper _mapper;
        public InstructorController(IInstructorService instructorService, IMapper mapper)
        {
            _instructorService = instructorService;
            _mapper = mapper;
            
        }
        [HttpGet]
        public IEnumerable<InstructorViewModel> Get()
        {
           var instructors =  _instructorService.Get();
             return _mapper.Map<IEnumerable<InstructorViewModel>>(instructors);
        }
        
        [HttpPost]
        public void Register(InstructorRegisterViewModel instructorViewModel)
        {
            var instructor = _mapper.Map<InstructorRegisterDTO>(instructorViewModel);
            _instructorService.Register(instructor);
        }
        [HttpPost]
        public void Login(InstructorLoginViewModel InstructorLoginViewModel)
        {

            var instructor = _mapper.Map<InstructorLoginDTO>(InstructorLoginViewModel);
            _instructorService.Login(instructor);
        }


    }
}
