using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Concrete
{
    public class IProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public IProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Tadd(Product entity)
        {
            _productDal.add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        

        public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        List<Product> IGenericService<Product>.TGetListAll()
        {
           return _productDal.GetListAll();
        }
    }
}
