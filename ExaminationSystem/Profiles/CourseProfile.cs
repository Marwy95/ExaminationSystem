using AutoMapper;
using ExaminationSystem.DTOs.Course;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Course;

namespace ExaminationSystem.Profiles
{
    public class CourseProfile :Profile
    {
        public CourseProfile()
        {
            CreateMap<CourseCreateViewModel, CourseCreateDTO>();
            CreateMap<CourseCreateDTO, Course>();
            CreateMap<CourseUpdateViewModel, CourseUpdateDTO>();
            CreateMap<CourseUpdateDTO, Course>();
            CreateMap<Course, CourseDTO>().ForMember(
                dst => dst.NumberOfExams,
                opt =>  opt.MapFrom(src => src.Exams.Count())
                );
            CreateMap<CourseDTO, CourseViewModel>();
        }

    }
}
