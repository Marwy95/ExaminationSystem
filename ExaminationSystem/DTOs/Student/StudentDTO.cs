namespace ExaminationSystem.DTOs.Student
{
    public class StudentDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
        public string Email { get; set; }


    }
}
