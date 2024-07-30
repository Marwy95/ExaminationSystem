using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExaminationSystem.DTOs.Course;
using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Instructors
{
    public class InstructorService :IInstructorService
    {
        private readonly IRepository<Instructor> _instructorRepository;
        private readonly IMapper _mapper;
        public InstructorService(IRepository<Instructor> instructorRepository, IMapper mapper) {
        
        _instructorRepository = instructorRepository;
            _mapper =mapper;

        }

        public void Register(InstructorRegisterDTO instructorCreateDTO)
        {
           var instructor=  _mapper.Map<Instructor>(instructorCreateDTO);
            _instructorRepository.Add(instructor);
            _instructorRepository.SaveChanges();

        }
        public void Login(InstructorLoginDTO instructorLoginDTO)
        {
            var instructor = _mapper.Map<Instructor>(instructorLoginDTO);
           var result =  _instructorRepository.Get(i => i.Email== instructor.Email).FirstOrDefault();
            if (result !=null)
            {
                if (result.Password == instructor.Password) return;
                else Console.WriteLine("invalid Password");
            }
            
            else Console.WriteLine("invalid email");
            
            
        }

        public IEnumerable<InstructorDTO> Get()
        {
            var instructors =_instructorRepository.GetAll();
            return instructors.ProjectTo<InstructorDTO>(_mapper.ConfigurationProvider).ToList();
        }




    }
}
