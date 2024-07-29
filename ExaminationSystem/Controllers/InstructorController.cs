
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
        //[HttpGet]
        //public IEnumerable<Instructor> GetAll()
        //{

        //    return _instructorRepository.GetAll();
        //}
        //[HttpGet]
        //public Instructor GetByID(int id)
        //{
        //    return _instructorRepository.GetByID(id);
        //}
        [HttpPost]
        public void Register(InstructorRegisterViewModel instructorViewModel)
        {
            var instructor = _mapper.Map<InstructorRegisterDTO>(instructorViewModel);
            _instructorService.Add(instructor);
        }
        //[HttpPost]
        //public void Login(Instructor instructor)
        //{
        //    _instructorRepository.Add(instructor);
        //    _instructorRepository.SaveChanges();
        //}
        

    }
}
