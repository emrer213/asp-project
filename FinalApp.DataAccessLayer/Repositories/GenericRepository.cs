using FinalApp.DataAccessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }

        public void add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<Product> GetProductsWithCategories()
        {
            throw new NotImplementedException();
        }
    }
}
