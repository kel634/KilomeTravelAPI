namespace KilomeTravelAPI.WebAPI.Models
{
    public class RentReturn
    {
        public int Id { get; set; }
        public required RentOrder RentOrder { get; set; }
        public DateTime ReturnTime { get; set; }
        public decimal FuelPenalty { get; set; }
        public decimal DamagePenalty { get; set; }
        public string? DamageDescription { get; set; }
    }
}
