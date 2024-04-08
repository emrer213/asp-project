using FinalApp.DataAccessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.DataAccessLayer.Repositories;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(SignalRContext context) : base(context)
        {
        }
    }
}
