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
        //public IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
        //{
        //    return GetAll().Select(selector);
        //}
        public T GetByID(int id)
        {
            return  GetAll().FirstOrDefault(x => x.ID == id);
        }
        public T Add(T entity)
        {
           _context.Add(entity);
            return entity;  
        }
        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);

        }
        public void Delete(int id)
        {
            T entity = _context.Find<T>(id);
            Delete(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void SaveChanges()
        {
            
            _context.SaveChanges();
        }
        public T First(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }
    }
}
