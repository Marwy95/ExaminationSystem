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
        public IEnumerable<CourseViewModel> Get(int instructorID)
        {

            var courses = _courseService.Get(instructorID);
            return courses.AsQueryable()
                          .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
        [HttpGet]
        public CourseViewModel GetById(int id)
        {

            var courseDTO = _courseService.GetById(id);
            var courseViewModel = _mapper.Map<CourseViewModel>(courseDTO);
            return courseViewModel;
        }
        [HttpPut]
        public ActionResult Update(CourseUpdateViewModel courseViewModel,int id, int instructorID)
        {

            var course = _mapper.Map<CourseUpdateDTO>(courseViewModel);
            var result = _courseService.Update(course,id, instructorID);
            if (result) return Ok();
            else return BadRequest(result);
        }
        [HttpDelete]
        public ActionResult Delete(int id, int instructorID)
        {
            var result = _courseService.Delete(id);
            if (result) return Ok();
            else return BadRequest(result);
        }


    }
}
