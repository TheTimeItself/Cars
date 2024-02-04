using CarsModels.Models;

namespace CarsBL.Interfaces
{
    public interface ICarService
    {
        public void Add(Car car);
        public void Remove(int id);
        public Car? GetByID(int id);
        public List<Car> GetAll();
        public List<Car> GetAllByManufactorerAfterCreation(int manufactorerId, DateTime afterDate);
    }
}
