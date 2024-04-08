using FinalApp.DataAccessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.DataAccessLayer.Repositories;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(SignalRContext context) : base(context)
        {
        }
    }
}
