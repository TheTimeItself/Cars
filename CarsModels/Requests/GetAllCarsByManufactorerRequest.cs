namespace CarsModels.Requests
{
    public class GetAllCarsByManufactorerRequest
    {
        public int ManufactorerID { get; set; }
        public DateTime DateAfter { get; set; }
    }
}
