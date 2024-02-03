using CarsModels.Models;

namespace CarsDL.Interfaces
{
    public interface IManufactorerRepository
    {
        List<Manufactorer> GetAll();
        Manufactorer? GetByID(int id);
        void Add(Manufactorer manufactorer);
        void Remove (int id);
    }
}
