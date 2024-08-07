using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExaminationSystem.DTOs.Student;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Students
{
    public class StudentService:IStudentService
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IMapper _mapper;
        public StudentService(IRepository<Student> studentRepository, IMapper mapper)
        {

            _studentRepository = studentRepository;
            _mapper = mapper;

        }

        public void Register(StudentRegisterDTO studentCreateDTO)
        {
            var student = _mapper.Map<Student>(studentCreateDTO);
            _studentRepository.Add(student);
            _studentRepository.SaveChanges();

        }
        public void Login(StudentLoginDTO studentLoginDTO)
        {
            var student = _mapper.Map<Student>(studentLoginDTO);

            var result = _studentRepository.Get(i => i.Email == student.Email).FirstOrDefault();
            if (result != null)
            {
                if (result.Password == student.Password) return;
                else Console.WriteLine("invalid Password");
            }

            else Console.WriteLine("invalid email");


        }

        public IEnumerable<StudentDTO> Get()
        {
            var students = _studentRepository.GetAll();
            return students.ProjectTo<StudentDTO>(_mapper.ConfigurationProvider).ToList();
        }

    }
}
