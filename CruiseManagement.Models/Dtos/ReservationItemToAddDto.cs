using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagement.Models.Dtos
{
    public class ReservationItemToAddDto
    {
        public int ProductId { get; set; }
        public int ReservationId { get; set; }
        public string ProductName { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public int AdultsPax { get; set; }
        public int ChildPax { get; set; }
        public int CompPax { get; set; }
        public decimal AdultPrice { get; set; }
        public decimal ChildPrice { get; set; }
        public decimal CompPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
