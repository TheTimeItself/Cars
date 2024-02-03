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
            throw new NotImplementedException();
        }

        public List<Manufactorer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Manufactorer? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
