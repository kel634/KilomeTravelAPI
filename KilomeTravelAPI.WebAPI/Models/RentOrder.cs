namespace KilomeTravelAPI.WebAPI.Models
{
    public class RentOrder
    {
        public DateTime ReservationTime { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerPhoneNumber { get; set; }
    }
}