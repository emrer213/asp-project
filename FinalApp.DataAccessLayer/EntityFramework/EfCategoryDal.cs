using FinalApp.DataAccessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.DataAccessLayer.Repositories;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }
    }
}
