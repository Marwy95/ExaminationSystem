using AutoMapper;
using ExaminationSystem.DTOs.Choices;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.NewFolder
{
    public class ChoiceService :IChoiceService
    {
        IMapper _mapper;
        IRepository<Choice> _choiceRepo;
        public ChoiceService(IMapper mapper,IRepository<Choice> choiceRepo)
        {
            _mapper = mapper;
            _choiceRepo = choiceRepo;
        }
        public IEnumerable<ChoiceDTO> GetAll(int questionID)
        {

            var choices = _choiceRepo.Get(c=>c.QuestionID == questionID).ToList();
            return _mapper.Map<IEnumerable<ChoiceDTO>>(choices);
            
        }
        public void Add(ChoiceCreateDTO choiceCreateDTO)
        {
            var choice = _mapper.Map<Choice>(choiceCreateDTO);
            _choiceRepo.Add(choice);
        }
        public void AddRange(IEnumerable<ChoiceCreateDTO> choicesCreateDTO)
        {
            var choices = _mapper.Map<IEnumerable<Choice>>(choicesCreateDTO);
            foreach (var choice in choices)
            {
                _choiceRepo.Add(choice);
                _choiceRepo.SaveChanges();
            }

        }
        //public IEnumerable<ChoiceCreateDTO> GetChoices() { 
        
        //}
        public void DeleteChoices(int questionID)
        {

            var choices = _choiceRepo.Get(c => c.QuestionID == questionID);
            foreach (var ch in choices)
            {
                _choiceRepo.Delete(ch.ID);
               

            }
            _choiceRepo.SaveChanges();
        }
        public void Update(IEnumerable<ChoiceUpdateDTO> choicesUpdateDTO)
        {
           foreach (var choiceUpdateDTO in choicesUpdateDTO)
            {
                var choice = _choiceRepo.GetByID(choiceUpdateDTO.ID);
                var updatedChoice = _mapper.Map<Choice>(choiceUpdateDTO);
                choice.IsRight = updatedChoice.IsRight;
                choice.Text = updatedChoice.Text;
                _choiceRepo.Update(choice);
                _choiceRepo.SaveChanges();
            }
           
        }
    }
}
