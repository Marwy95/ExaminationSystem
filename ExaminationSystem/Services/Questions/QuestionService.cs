using AutoMapper;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Repositories;
using ExaminationSystem.Models;
using ExaminationSystem.DTOs.Course;
using AutoMapper.QueryableExtensions;
namespace ExaminationSystem.Services.Questions
{
    public class QuestionService:IQuestionService
    {
        IMapper _mapper;
        IRepository<Question> _questionRepo;
        public QuestionService(IMapper mapper,IRepository<Question> questionRepo)
        {
            _mapper = mapper;
            _questionRepo = questionRepo;   
        }
        public IEnumerable<QuestionDTO> GetAll(int instructorID)
        {
           
            var questions = _questionRepo.Get(q=>q.InstructorID==instructorID);
            return questions.ProjectTo<QuestionDTO>(_mapper.ConfigurationProvider).ToList();
        }
        public void Create(QuestionCreateDTO questionCreateDTO, int instructorID)
        {
            var question = _mapper.Map<Question>(questionCreateDTO);
            question.InstructorID = instructorID;
            _questionRepo.Add(question);
            _questionRepo.SaveChanges();
        }
        public bool Update(QuestionUpdateDTO questionUpdateDTO, int instructorID)
        {
            var question = _questionRepo.GetByID(questionUpdateDTO.ID);
            if (question == null) return false;
            if (question.InstructorID != instructorID) return false;
           
            else
            {
                _mapper.Map<Question>(questionUpdateDTO);
                question.Text = questionUpdateDTO.Text;
                question.Level = questionUpdateDTO.Level;
                _questionRepo.Update(question);
                _questionRepo.SaveChanges();
                return true;
            }
        }
        public void Delete(int id,int instructorID)
        {
            var question = _questionRepo.GetByID(id);
            _questionRepo.Delete(question);
            _questionRepo.SaveChanges();
        }

    }
}
