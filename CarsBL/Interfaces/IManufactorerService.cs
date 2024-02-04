using CarsModels.Models;

namespace CarsBL.Interfaces
{
    public interface IManufactorerService
    {
        public void Add(Manufactorer manufactorer);
        public void Remove(int id);
        public Manufactorer? GetByID(int id);
        public List<Manufactorer> GetAll();
    }
}
