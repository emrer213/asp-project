using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class IDiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public IDiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        
        public void Tadd(Discount entity)
        {
            _discountDal.add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
