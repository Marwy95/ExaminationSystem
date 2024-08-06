using AutoMapper;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Mediators.Questions;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Questions;
using ExaminationSystem.ViewModels.Question;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class QuestionController :ControllerBase
    {
        IMapper _mapper;
        IQuestionService _questionService;
        IQuestionMediator _questionMediator;
        public QuestionController(IMapper mapper,IQuestionService questionService,IQuestionMediator questionMediator)
        {
            _mapper = mapper;
            _questionService = questionService; 
            _questionMediator = questionMediator;
        }
        [HttpPost]
        public IActionResult Create(QuestionCreateViewModel questionCreateViewModel,int instructorID)
        {
            var questionDTO = _mapper.Map<QuestionCreateDTO>(questionCreateViewModel);
            _questionService.Create(questionDTO, instructorID);
            return Ok();

        }
        [HttpPut]
        public void Update(QuestionUpdateViewModel questionUpdateViewModel,int instructorID)
        {
            var questionDTO = _mapper.Map<QuestionUpdateDTO>(questionUpdateViewModel);
 
            _questionMediator.UpdateQuestion(questionDTO, instructorID);
        }
        [HttpDelete]
        public void Delete(int instructorID,int id)
        {
            _questionMediator.DeleteQuestion(id,instructorID); 
        }
        [HttpGet]
        public IEnumerable<QuestionViewModel> Get(int instructorID)
        {
           var questionsDTO =  _questionService.GetAll(instructorID);
            return _mapper.Map< IEnumerable<QuestionViewModel>>(questionsDTO);
            //return questionsDTO.ProjectTo<QuestionViewModel>(_mapper.ConfigurationProvider).ToList();
        }
    }
}
