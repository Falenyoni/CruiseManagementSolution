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
        public int Adults { get; set; }
        public int Child { get; set; }
        public int Comp { get; set; }
    }
}
