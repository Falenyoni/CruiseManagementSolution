using CruiseManagement.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace CruiseManagement.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
