using CarsModels.Models;
using CarsBL.Interfaces;
using CarsDL.Interfaces;

namespace CarsBL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Add(Car car)
        {
            _carRepository.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public List<Car> GetAllByManufactorerAfterCreation(int manufacturerId, DateTime afterDate)
        {
            var result = _carRepository.GetAllByManufactorer(manufacturerId);

            return result.Where(b => b.ManufacturerId == manufacturerId).ToList();
        }

        public Car? GetByID(int id)
        {
            return _carRepository.GetByID(id);
        }

        public void Remove(int id)
        {
            _carRepository.Remove(id);
        }
    }
}
