using CarsModels.Models;

namespace CarsModels.Responses
{
    public class GetAllCarsByManufacturerRespose
    {
        public Manufacturer? Manufacturer { get; set; }
        public List<Car>? Cars { get; set; }
    }
}
