using FinalApp.EntityLayer.Entities;

namespace FinalApp.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}
