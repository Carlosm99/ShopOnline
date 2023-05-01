using Microsoft.AspNetCore.Components;
using Shoponline.Web.Services.Contracts;
using ShopOnline.Models.Dtos;

namespace Shoponline.Web.Pages
{
    public class Productsbase: ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto>? Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
