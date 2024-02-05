using CarsDL.InMemoryDb;
using CarsDL.Interfaces;
using CarsModels.Models;

namespace CarsDL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            StaticData.Cars.Add(car);
        }

        public List<Car> GetAll()
        {
            return StaticData.Cars;
        }

        public List<Car> GetAllByManufactorer(int manufactorerId)
        {
            return StaticData.Cars.Where(c => c.ManufacturerId == manufactorerId).ToList();
        }

        public Car? GetByID(int id)
        {
            return StaticData.Cars.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var car = GetByID(id);
            if (car == null)
            {
                return;
            }
            StaticData.Cars.Remove(car);
        }
    }
}
