using CarsModels.Models;
using CarsBL.Interfaces;
using CarsDL.Interfaces;

namespace CarsBL.Services
{
    public class ManufactorerService : IManufactorerService
    {
        private readonly IManufactorerService _manufactorerService;

        public ManufactorerService(IManufactorerService manufactorerService)
        {
            _manufactorerService = manufactorerService;
        }

        public void Add(Manufactorer manufactorer)
        {
            _manufactorerService.Add(manufactorer);
        }

        public List<Manufactorer> GetAll()
        {
            return _manufactorerService.GetAll();
        }

        public Manufactorer? GetByID(int id)
        {
            return _manufactorerService.GetByID(id);
        }

        public void Remove(int id)
        {
            _manufactorerService.Remove(id);
        }
    }
}
