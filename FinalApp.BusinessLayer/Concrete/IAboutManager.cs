using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class IAboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public IAboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Tadd(About entity)
        {
            _aboutDal.add(entity);

        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }

        List<About> IGenericService<About>.TGetListAll()
        {
            return _aboutDal.GetListAll();
        }
    }
}
