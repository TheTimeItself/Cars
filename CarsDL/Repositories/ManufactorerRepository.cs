using CarsModels.Models;
using CarsDL.InMemoryDb;
using CarsDL.Interfaces;

namespace CarsDL.Repositories
{
    public class ManufactorerRepository : IManufactorerRepository
    {
        public void Add(Manufactorer manufactorer)
        {
            InMemoryDb.InMemoryDb.Manufactorers.Add(manufactorer);
        }

        public List<Manufactorer> GetAll()
        {
            return InMemoryDb.InMemoryDb.Manufactorers;
        }

        public Manufactorer? GetByID(int id)
        {
            return InMemoryDb.InMemoryDb.Manufactorers.First(a => a.id == id);
        }

        public void Remove(int id)
        {
            var manufactorer = GetByID(id);
            if (manufactorer == null)
            {
                return;
            }
            InMemoryDb.InMemoryDb.Manufactorers.Remove(manufactorer);
        }
    }
}
