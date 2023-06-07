namespace KilomeTravelAPI.WebAPI.Models
{
    public class RentalItemType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool Enabled { get; set; }
        public bool HasFuel { get; set; }
    }
}
