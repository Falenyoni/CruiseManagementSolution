using CruiseManagement.Api.Entities;
using CruiseManagement.Models.Dtos;

namespace CruiseManagement.Api.Extenstions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories)
        {
            return from product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        CategoryId = product.CategoryId,
                        CategoryName = productCategory.Name
                    };
        }

        public static ProductDto ConvertToDto(this Product product, ProductCategory productCategory)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryId = product.CategoryId,
                CategoryName = productCategory.Name
            };
        }

        public static IEnumerable<ReservationItemDto> ConvertToDto(this IEnumerable<ReservationItem> reservationItems, IEnumerable<Product> products)
        {
            return (from reservationItem in reservationItems
                    join product in products
                    on reservationItem.ProductId equals product.Id
                    select new ReservationItemDto
                    {
                        Id = reservationItem.Id,
                        ProductId = product.Id,
                        ProductName = product.Name,
                        PickupPoint = reservationItem.PickupPoint,
                        Destination = reservationItem.Destination,
                        Adults = reservationItem.AdultPax,
                        Child = reservationItem.ChildPax,
                        Comp = reservationItem.CompPax,
                        TravelDate = reservationItem.TravelDate

                    }).ToList();
        }

        public static ReservationItemDto ConvertToDto(this ReservationItemDto reservationItem, Product product)
        {
            return new ReservationItemDto
            {
                Id = reservationItem.Id,
                ProductId = product.Id,
                ProductName = product.Name,
                PickupPoint = reservationItem.PickupPoint,
                Destination = reservationItem.Destination,
                Adults = reservationItem.Adults,
                Child = reservationItem.Child,
                Comp = reservationItem.Comp,
                TravelDate = reservationItem.TravelDate

            };
        }
    }
}
