using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExamController
    {
        private readonly IRepository<Exam> _examRepository;
        public ExamController(IRepository<Exam> examRepository)
        {
            _examRepository = examRepository;
        }
        [HttpPost]
        public void Add(Exam exam) ////instructor id from header
        {
             _examRepository.Add(exam);
            _examRepository.SaveChanges();
        }
        [HttpGet]
        
        public IEnumerable<Exam> Get(int id) //instructor id from header
        {
            return _examRepository.Get(e=>e.InstructorID==id);
        }

    }
}
