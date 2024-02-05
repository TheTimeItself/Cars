using CarsModels.Models;
using CarsBL.Interfaces;
using CarsDL.Interfaces;

namespace CarsBL.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public void Add(Manufacturer manufacturer)
        {
            _manufacturerRepository.Add(manufacturer);
        }

        public List<Manufacturer> GetAll()
        {
            return _manufacturerRepository.GetAll();
        }

        public Manufacturer? GetByID(int id)
        {
            return _manufacturerRepository.GetByID(id);
        }

        public void Remove(int id)
        {
            _manufacturerRepository.Remove(id);
        }
    }
}
