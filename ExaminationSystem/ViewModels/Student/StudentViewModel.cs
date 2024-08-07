namespace ExaminationSystem.ViewModels.Student
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
        public string Email { get; set; }
    }
}
