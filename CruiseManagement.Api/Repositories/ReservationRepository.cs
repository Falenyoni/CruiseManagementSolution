using CruiseManagement.Api.Data;
using CruiseManagement.Api.Entities;
using CruiseManagement.Api.Repositories.Contracts;
using CruiseManagement.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CruiseManagement.Api.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CruiseManagementDbContext _cruiseManagementDbContext;

        public ReservationRepository(CruiseManagementDbContext cruiseManagementDbContext)
        {
            this._cruiseManagementDbContext = cruiseManagementDbContext;
        }
        public async Task<ReservationItem> AddItem(ReservationItemToAddDto reservationItemToAddDto)
        {
            if(await ReservationItemExist(reservationItemToAddDto.ReservationId, reservationItemToAddDto.ProductId) == false)
            {
                var item = await (from product in this._cruiseManagementDbContext.Products
                                  where product.Id == reservationItemToAddDto.ProductId
                                  select new ReservationItem
                                  {
                                      ReservationId = reservationItemToAddDto.ReservationId,
                                      ProductId = product.Id,
                                      Destination = reservationItemToAddDto.Destination,
                                      AdultPax = reservationItemToAddDto.AdultsPax,
                                      ChildPax = reservationItemToAddDto.ChildPax,
                                      CompPax = reservationItemToAddDto.CompPax,
                                      PickupPoint = reservationItemToAddDto.PickupPoint,
                                      AdultPrice = reservationItemToAddDto.AdultPrice,
                                      ChildPrice = reservationItemToAddDto.ChildPrice,
                                      CompPrice = reservationItemToAddDto.CompPrice,
                                      Travelled = false
                                  }).SingleOrDefaultAsync();

                if(item != null )
                {
                    var result = await this._cruiseManagementDbContext.ReservationItems.AddAsync(item);
                    await this._cruiseManagementDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
            return null;
        }

        public async Task<ReservationItem> DeleteItem(int id)
        {
            var item  = await this._cruiseManagementDbContext.ReservationItems.FindAsync(id);
            if(item != null )
            {
                this._cruiseManagementDbContext.ReservationItems.Remove(item);
                await this._cruiseManagementDbContext.SaveChangesAsync();
            }
            return item;
        }

        public async Task<ReservationItem> GetItem(int id)
        {
            return await (from reservation in this._cruiseManagementDbContext.Reservations
                          join reservationItem in this._cruiseManagementDbContext.ReservationItems
                          on reservation.Id equals reservationItem.ReservationId
                          where reservationItem.Id == id
                          select new ReservationItem
                          {
                              Id = reservation.Id,
                              ProductId = reservationItem.ProductId,
                              Destination = reservationItem.Destination,
                              AdultPax = reservationItem.AdultPax,
                              ChildPax = reservationItem.ChildPax,
                              CompPax = reservationItem.CompPax,
                              PickupPoint = reservationItem.PickupPoint,
                              AdultPrice = reservationItem.AdultPrice,
                              ChildPrice = reservationItem.ChildPrice,
                              CompPrice = reservationItem.CompPrice,
                              Travelled = reservationItem.Travelled
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ReservationItem>> GetItems(DateTime travelDate)
        {
            return await (from reservation in this._cruiseManagementDbContext.Reservations
                         join reservationItem in this._cruiseManagementDbContext.ReservationItems
                         on reservation.Id equals reservationItem.ReservationId
                         where reservationItem.TravelDate == travelDate
                         select new ReservationItem
                         {
                             Id = reservation.Id,
                             ProductId = reservationItem.ProductId,
                             Destination = reservationItem.Destination,
                             AdultPax = reservationItem.AdultPax,
                             ChildPax = reservationItem.ChildPax,
                             CompPax = reservationItem.CompPax,
                             PickupPoint = reservationItem.PickupPoint,
                             AdultPrice = reservationItem.AdultPrice,
                             ChildPrice = reservationItem.ChildPrice,
                             CompPrice = reservationItem.CompPrice,
                             Travelled = reservationItem.Travelled
                         }).ToListAsync();
        }

        public async Task<ReservationItem> UpdateQty(int id, ReservationItemUpdateDto reservationItemUpdateDto)
        {
            var item = await this._cruiseManagementDbContext.ReservationItems.FindAsync(id);
            if(item != null)
            {
                item.AdultPrice = reservationItemUpdateDto.AdultPrice;
                item.ChildPrice = reservationItemUpdateDto.ChildPrice;
                item.CompPrice =  reservationItemUpdateDto.CompPrice;
                item.PickupPoint = reservationItemUpdateDto.PickupPoint;
                item.Destination = reservationItemUpdateDto.Destination;
                item.AdultPax = reservationItemUpdateDto.AdultsPax;
                item.ChildPax = reservationItemUpdateDto.ChildPax;
                item.CompPax = reservationItemUpdateDto.CompPax;
                item.TravelDate = reservationItemUpdateDto.TravelDate;


                await this._cruiseManagementDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }

        private async Task<bool> ReservationItemExist(int reservationId, int productId)
        {
            return await this._cruiseManagementDbContext.ReservationItems.AnyAsync(r => r.ReservationId == reservationId && r.ProductId == productId);
        }
    }
}
