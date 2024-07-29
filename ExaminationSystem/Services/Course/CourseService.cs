using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExaminationSystem.DTOs.Course;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Courses
{
    public class CourseService:ICourseService
    {
        private readonly IRepository<Course> _courseRepository;
        private readonly IMapper _mapper;
        public CourseService(IRepository<Course> courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            
        }
        public void Add(CourseCreateDTO courseDTO)

        {
            var course = _mapper.Map<Course>(courseDTO);
            _courseRepository.Add(course);
            _courseRepository.SaveChanges();
        }
        public IEnumerable<CourseDTO> Get()
        {

            var courses = _courseRepository.GetAll();
            //return _mapper.ProjectTo<CourseDTO>(courses);
            return courses.ProjectTo<CourseDTO>(_mapper.ConfigurationProvider).ToList();

        }

    }
}
