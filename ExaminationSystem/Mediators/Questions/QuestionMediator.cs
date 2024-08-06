using ExaminationSystem.DTOs.Choices;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Models;
using ExaminationSystem.Services.NewFolder;
using ExaminationSystem.Services.Questions;

namespace ExaminationSystem.Mediators.Questions
{
    public class QuestionMediator:IQuestionMediator
    {
        IQuestionService _questionService;
        IChoiceService _choiceService;
        public QuestionMediator(IQuestionService questionService, IChoiceService choiceService)
        {
            _questionService = questionService;
            _choiceService = choiceService; 
        }
        public void UpdateQuestion(QuestionUpdateDTO questionUpdateDTO, int instructorID)
        {
            _questionService.Update(questionUpdateDTO,instructorID);

            _choiceService.Update(questionUpdateDTO.choices);


        }
        public void DeleteQuestion(int id, int instructorID)
        {
            _questionService.Delete(id, instructorID);
            
            _choiceService.DeleteChoices(id);
            

        }
    }
}
