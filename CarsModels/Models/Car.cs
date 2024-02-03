namespace CarsModels.Models
{
    public record Car
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string Model { get; set; } = string.Empty;
        public int price { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
