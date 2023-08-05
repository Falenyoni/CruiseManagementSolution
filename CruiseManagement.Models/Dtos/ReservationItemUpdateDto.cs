using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagement.Models.Dtos
{
    public class ReservationItemUpdateDto
    {
        public int ReservationItemId { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public int AdultsPax { get; set; }
        public int ChildPax { get; set; }
        public int CompPax { get; set; }
        public Decimal AdultPrice { get; set; }
        public Decimal ChildPrice { get; set; }
        public Decimal CompPrice { get; set; }
        public DateTime TravelDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
