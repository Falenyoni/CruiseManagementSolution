namespace CruiseManagement.Api.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int AgentId { get; set; }
        public int UserId { get; set; }
        public string Notes { get; set; }
    }
}
