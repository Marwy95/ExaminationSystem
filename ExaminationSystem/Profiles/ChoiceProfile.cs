using AutoMapper;
using ExaminationSystem.DTOs.Choices;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Choices;

namespace ExaminationSystem.Profiles
{
    public class ChoiceProfile : Profile
    {
        public ChoiceProfile()
        {
            CreateMap<ChoiceCreateViewModel, ChoiceCreateDTO>();
            CreateMap<ChoiceCreateDTO,Choice>();
            CreateMap<ChoiceUpdateViewModel, ChoiceUpdateDTO>();
            CreateMap<ChoiceUpdateDTO, Choice>();
            //
            CreateMap<Choice, ChoiceDTO>();
            CreateMap<ChoiceDTO, ChoiceViewModel>();
        }
    }
}
