using ExaminationSystem.DTOs.Student;

namespace ExaminationSystem.Services.Students
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> Get();
        void Register(StudentRegisterDTO studentCreateDTO);
        void Login(StudentLoginDTO studentLoginDTO);
    }
}
