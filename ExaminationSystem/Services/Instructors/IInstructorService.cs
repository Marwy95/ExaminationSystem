using ExaminationSystem.DTOs.Instructor;
namespace ExaminationSystem.Services.Instructors
{
    public interface IInstructorService
    {
        void Add(InstructorRegisterDTO instructorCreateDTO);
    }
}
