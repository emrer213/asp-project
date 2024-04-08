using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class ICategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public ICategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        

        public void Tadd(Category entity)
        {
            _categoryDal.add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetListAll() { return _categoryDal.GetListAll(); }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
