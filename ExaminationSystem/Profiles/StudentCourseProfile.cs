using AutoMapper;
using ExaminationSystem.DTOs.Course;
using ExaminationSystem.DTOs.StudentCourse;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Course;
using ExaminationSystem.ViewModels.StudentCourse;

namespace ExaminationSystem.Profiles
{
    public class StudentCourseProfile :Profile
    {
        public StudentCourseProfile()
        {
            CreateMap<StudentCourseViewModel, StudentCourseDTO>();
            CreateMap<StudentCourseDTO, StudentCourse>();
            
        }

    }
}
