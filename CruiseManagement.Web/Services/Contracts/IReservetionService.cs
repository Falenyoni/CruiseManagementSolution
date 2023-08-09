using CruiseManagement.Models.Dtos;

namespace CruiseManagement.Web.Services.Contracts
{
    public interface IReservetionService
    {
        Task<List<ReservationItemDto>> GetItems(DateTime reservationDate);
        Task<ReservationItemDto> AddItem(ReservationItemToAddDto reservationItemToAddDto);
        Task<ReservationItemDto> DeleteItem(int id);
        Task<ReservationItemDto> UpdateQty(ReservationItemUpdateDto reservationItemUpdateDto);

        //event Action<int> OnShoppingCartChanged;
        //void RaiseEventOnShoppingCartChanged(int totalQty);
    }
}
