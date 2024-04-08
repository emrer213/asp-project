namespace FinalApp.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Tadd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetById(int id);
        List<T> TGetListAll();
    }
}
