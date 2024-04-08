using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class IFeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public IFeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

       

        public void Tadd(Feature entity)
        {
            _featureDal.add(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
