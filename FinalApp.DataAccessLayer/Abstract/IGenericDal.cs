using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetListAll();
        List<Product> GetProductsWithCategories();
    }
}
