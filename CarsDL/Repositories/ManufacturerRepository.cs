using CarsDL.InMemoryDb;
using CarsDL.Interfaces;
using CarsModels.Models;

namespace CarsDL.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        public void Add(Manufacturer Manufacturer)
        {
            StaticData.Manufacturers.Add(Manufacturer);
        }

        public List<Manufacturer> GetAll()
        {
            return StaticData.Manufacturers;
        }

        public Manufacturer? GetByID(int id)
        {
            return StaticData.Manufacturers.First(a => a.id == id);
        }

        public void Remove(int id)
        {
            var Manufacturer = GetByID(id);
            if (Manufacturer == null)
            {
                return;
            }
            StaticData.Manufacturers.Remove(Manufacturer);
        }
    }
}
