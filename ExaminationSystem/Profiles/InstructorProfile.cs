using AutoMapper;
using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instructor;

namespace ExaminationSystem.Profiles
{
    public class InstructorProfile:Profile
    {
        public InstructorProfile()
        {
            //Register
            CreateMap<InstructorRegisterViewModel, InstructorRegisterDTO>();
            CreateMap<InstructorRegisterDTO, Instructor>();
            //Login
            CreateMap<InstructorLoginViewModel, InstructorLoginDTO>();
            CreateMap<InstructorLoginDTO, Instructor>();
            //Get
            CreateMap<Instructor, InstructorDTO>()
                .ForMember(dst => dst.NoOfCourses,
                 opt => opt.MapFrom(src => src.Courses.Count()))
                 .ForMember(dst => dst.NoOfExams,
                 opt => opt.MapFrom(src => src.Exams.Count()));
            CreateMap<InstructorDTO, InstructorViewModel> ();
        }

    }
}
