using CarsModels.Models;
using CarsDL.InMemoryDb;
using CarsDL.Interfaces;

namespace CarsDL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            InMemoryDb.InMemoryDb.Cars.Add(car);
        }

        public List<Car> GetAll()
        {
            return InMemoryDb.InMemoryDb.Cars;
        }

        public List<Car> GetAllByManufactorer(int manufactorerId)
        {
            return InMemoryDb.InMemoryDb.Cars.Where(c=> c.ManufacturerId == manufactorerId).ToList();
        }

        public Car? GetByID(int id)
        {
            return InMemoryDb.InMemoryDb.Cars.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var car = GetByID(id);
            if (car == null)
            {
                return;
            }
            InMemoryDb.InMemoryDb.Cars.Remove(car);
        }
    }
}
