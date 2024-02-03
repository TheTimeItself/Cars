using CarsModels.Models;

namespace CarsDL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        void Add(Car car);
        void Remove(int id);
        Car? GetByID(int id);
        List<Car> GetAllByManufactorer(int manufactorerId);
    }
}
