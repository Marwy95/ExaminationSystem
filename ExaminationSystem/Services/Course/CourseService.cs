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
        public IEnumerable<CourseDTO> Get(int instructorID)
        {

            var courses = _courseRepository.Get(c=>c.InstructorID== instructorID);
            return courses.ProjectTo<CourseDTO>(_mapper.ConfigurationProvider).ToList();
        }
        public bool Update(CourseUpdateDTO courseDTO,int id,int instructorID)
        {
            var course = _courseRepository.GetByID(id);
            if (course.InstructorID != instructorID) return false;
            else
            {
                var Updatedcourse = _mapper.Map<Course>(courseDTO);
                if (course != null)
                {
                    course.CreditHours = Updatedcourse.CreditHours;
                    course.Name = Updatedcourse.Name;
                    _courseRepository.Update(course);
                    _courseRepository.SaveChanges();
                    return true;
                }
                return false;
            }
            

        }
        public bool Delete(int id)
        {
            var course = _courseRepository.GetByID(id);
            if ((course!=null))
            {
                _courseRepository.Delete(course);
                _courseRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
