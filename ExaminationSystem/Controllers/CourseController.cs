using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExaminationSystem.DTOs.Course;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels.Course;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }
        [HttpPost]
        public void Add(CourseCreateViewModel courseViewModel)
        {
            var course = _mapper.Map<CourseCreateDTO>(courseViewModel);
            _courseService.Add(course);
        }
        [HttpGet]
        public IEnumerable<CourseViewModel> Get()
        {

            var courses = _courseService.Get();
            //return _mapper.Map<IEnumerable<CourseViewModel>>(courses);
            return courses.AsQueryable()
                          .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }

    }
}
