using AutoMapper;
using ExaminationSystem.DTOs.Student;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Student;

namespace ExaminationSystem.Profiles
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentRegisterViewModel, StudentRegisterDTO>();
            CreateMap<StudentRegisterDTO, Student>();

            CreateMap<StudentLoginViewModel, StudentLoginDTO>();
            CreateMap<StudentLoginDTO, Student>();

            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, StudentViewModel>();
        }
        
    }
}
