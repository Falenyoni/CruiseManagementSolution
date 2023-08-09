using CruiseManagement.Api.Entities;
using CruiseManagement.Models.Dtos;

namespace CruiseManagement.Api.Repositories.Contracts
{
    public interface IReservationRepository
    {
        Task<ReservationItem> AddItem(ReservationItemToAddDto cartItemDto);
        Task<ReservationItem> UpdateQty(int id, ReservationItemUpdateDto cartItemDto);
        Task<ReservationItem> DeleteItem(int id);
        Task<ReservationItem> GetItem(int id);
        Task<IEnumerable<ReservationItem>> GetItems(DateTime travelDate);
    }
}
