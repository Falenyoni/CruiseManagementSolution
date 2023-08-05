using CruiseManagement.Api.Data;
using CruiseManagement.Api.Entities;
using CruiseManagement.Api.Repositories.Contracts;
using CruiseManagement.Models.Dtos;

namespace CruiseManagement.Api.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CruiseManagementDbContext _cruiseManagementDbContext;

        public ReservationRepository(CruiseManagementDbContext cruiseManagementDbContext)
        {
            this._cruiseManagementDbContext = cruiseManagementDbContext;
        }
        public Task<ReservationItem> AddItem(ReservationItemToAddDto cartItemDto)
        {
            throw new NotImplementedException();
        }

        public Task<ReservationItem> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ReservationItem> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReservationItem>> GetItems(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<ReservationItem> UpdateQty(int id, ReservationItemUpdateDto cartItemDto)
        {
            throw new NotImplementedException();
        }
    }
}
