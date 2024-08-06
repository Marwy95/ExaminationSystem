using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Models;

namespace ExaminationSystem.Services.Questions
{
    public interface IQuestionService
    {
        void Create(QuestionCreateDTO questionCreateDTO, int instructorID);
        bool Update(QuestionUpdateDTO questionUpdateDTO,int instructorID);
        void Delete(int instructorID, int questionID);
        IEnumerable<QuestionDTO> GetAll(int instructorID);
    }
}
