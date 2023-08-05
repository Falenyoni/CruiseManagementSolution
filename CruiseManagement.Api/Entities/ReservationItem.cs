namespace CruiseManagement.Api.Entities
{
    public class ReservationItem
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int ProductId { get; set; }
        public int AdultPax { get; set; }
        public int ChildPax { get; set; }
        public int CompPax { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public int AdultPrice { get; set; }
        public int ChildPrice { get; set; }
        public int CompPrice { get; set; }
        public bool Travelled { get; set; }
    }
}
