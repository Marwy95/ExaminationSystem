using AutoMapper;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.ViewModels.Question;
using ExaminationSystem.Models;

namespace ExaminationSystem.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile() {
            CreateMap<QuestionCreateViewModel, QuestionCreateDTO>();
            CreateMap<QuestionCreateDTO, Question>();
            CreateMap<QuestionUpdateViewModel, QuestionUpdateDTO>();
            CreateMap<QuestionUpdateDTO, Question>();
            CreateMap<Question, QuestionDTO>();
            CreateMap<QuestionDTO, QuestionViewModel>();

        }
    }
}
