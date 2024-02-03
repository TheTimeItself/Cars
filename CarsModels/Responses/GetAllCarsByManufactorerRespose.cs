using CarsModels.Models;

namespace CarsModels.Responses
{
    public class GetAllCarsByManufactorerRespose
    {
        public Manufactorer Manufactorer { get; set; }
        public List<Car> Cars { get; set; };
    }
}
