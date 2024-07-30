using ExaminationSystem.DTOs.Instructor;
namespace ExaminationSystem.Services.Instructors
{
    public interface IInstructorService
    {
        IEnumerable<InstructorDTO> Get();
        void Register(InstructorRegisterDTO instructorCreateDTO);
        void Login(InstructorLoginDTO instructorLoginDTO);
    }
}
