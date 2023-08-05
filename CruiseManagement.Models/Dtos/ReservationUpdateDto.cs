using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagement.Models.Dtos
{
    public class ReservationUpdateDto
    {
        public int ReservationId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int AgentId { get; set; }
        public int UserId { get; set; }
        public string Notes { get; set; }
    }
}
