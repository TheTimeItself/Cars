using CarsModels.Models;

namespace CarsDL.Interfaces
{
    public interface IManufacturerRepository
    {
        List<Manufacturer> GetAll();
        Manufacturer? GetByID(int id);
        void Add(Manufacturer Manufacturer);
        void Remove(int id);
    }
}
