namespace KilomeTravelAPI.WebAPI.Models
{
    public class RentalItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int RentalItemTypeId { get; set; }
        public RentalItemType RentalItemType { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
