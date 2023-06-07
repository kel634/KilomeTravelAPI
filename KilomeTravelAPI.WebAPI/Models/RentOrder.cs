namespace KilomeTravelAPI.WebAPI.Models
{
    public class RentOrder
    {
        public int Id { get; set; }
        public required RentalItem RentalItem { get; set; }
        public DateTime ReservationTime { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhoneNumber { get; set; }
    }
}