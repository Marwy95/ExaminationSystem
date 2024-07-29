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
            CreateMap<InstructorRegisterViewModel, InstructorRegisterDTO>();
            CreateMap<InstructorRegisterDTO, Instructor>();
        }

    }
}
