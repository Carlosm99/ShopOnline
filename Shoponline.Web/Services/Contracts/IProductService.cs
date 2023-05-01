using ShopOnline.Models.Dtos;

namespace Shoponline.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    
    }
}
