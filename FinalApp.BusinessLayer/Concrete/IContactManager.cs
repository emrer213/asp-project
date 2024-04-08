using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class IContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public IContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        

        public void Tadd(Contact entity)
        {
            _contactDal.add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetListAll()
        { return _contactDal.GetListAll(); }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
