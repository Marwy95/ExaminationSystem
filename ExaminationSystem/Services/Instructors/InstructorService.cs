using AutoMapper;
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
        public void Add(InstructorRegisterDTO instructorCreateDTO)
        {
           var instructor=  _mapper.Map<Instructor>(instructorCreateDTO);
            _instructorRepository.Add(instructor);
            _instructorRepository.SaveChanges();

        }


        
    }
}
