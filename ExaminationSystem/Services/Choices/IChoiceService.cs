using ExaminationSystem.DTOs.Choices;
using ExaminationSystem.Models;

namespace ExaminationSystem.Services.NewFolder
{
    public interface IChoiceService
    {
        void AddRange(IEnumerable<ChoiceCreateDTO> choicesCreateDTO);
        void Add(ChoiceCreateDTO choiceCreateDTO);
        void DeleteChoices(int questionID);
        void Update(IEnumerable<ChoiceUpdateDTO> choicesUpdateDTO);
        IEnumerable<ChoiceDTO> GetAll(int questionID);
    }
}
