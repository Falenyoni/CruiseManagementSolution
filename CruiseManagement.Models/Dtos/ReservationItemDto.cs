using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagement.Models.Dtos
{
    public class ReservationItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ReservationId { get; set; }
        public string ProductName { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public int Adults { get; set; }
        public int Child { get; set; }
        public int Comp { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
