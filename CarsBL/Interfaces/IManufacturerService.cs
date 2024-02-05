using CarsModels.Models;

namespace CarsBL.Interfaces
{
    public interface IManufacturerService
    {
        public void Add(Manufacturer Manufacturer);
        public void Remove(int id);
        public Manufacturer? GetByID(int id);
        public List<Manufacturer> GetAll();
    }
}
