using FinalApp.EntityLayer.Entities;

namespace FinalApp.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
