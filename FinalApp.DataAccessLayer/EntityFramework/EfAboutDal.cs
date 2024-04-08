using FinalApp.DataAccessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.DataAccessLayer.Repositories;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {

        }
    }
}
