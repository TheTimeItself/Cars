namespace CarsModels.Requests
{
    public class GetAllCarsByManufacturerRequest
    {
        public int ManufacturerID { get; set; }
        public DateTime DateAfter { get; set; }
    }
}
