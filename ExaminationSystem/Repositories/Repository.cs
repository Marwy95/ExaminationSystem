using ExaminationSystem.Data;
using ExaminationSystem.Migrations;
using ExaminationSystem.Models;
using System.Linq;
using System.Linq.Expressions;

namespace ExaminationSystem.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
         private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context) { 
            _context = context;

        }
        public IQueryable<T> GetAll()
        {

            return _context.Set<T>().Where(T => !T.IsDeleted);
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }
        public T GetByID(int id)
        {
            return GetAll().FirstOrDefault(x => x.ID == id);
        }
        public void Add(T entity)
        {
            _context.Add(entity);
        }
        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);

        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void SaveChanges()
        {
            
            _context.SaveChanges();
        }
    }
}
