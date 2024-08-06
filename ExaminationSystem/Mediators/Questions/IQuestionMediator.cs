using ExaminationSystem.DTOs.Question;
using ExaminationSystem.ViewModels.Question;

namespace ExaminationSystem.Mediators.Questions
{
    public interface IQuestionMediator
    {
        void UpdateQuestion(QuestionUpdateDTO questionUpdateDTO,int instructorID);
        void DeleteQuestion(int id,int instructorID);
    }
}
