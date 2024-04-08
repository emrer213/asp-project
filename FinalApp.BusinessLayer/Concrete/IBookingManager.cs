using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class IBookingManager : IBookingService
    //Entitylerden gelen veriyi ekleme güncelleme silme işlemlerini yapar 
    {
        private readonly IBookingDal _bookingDal;//Dependency Injection için
        public IBookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

       

        public void Tadd(Booking entity)
        {
            _bookingDal.add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> TGetListAll() { return _bookingDal.GetListAll(); }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
