using CarsModels.Models;

namespace CarsDL.InMemoryDb
{
    public static class StaticData
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                ManufacturerId = 1,
                Model = "Lancer",
                price = 15000,
                CreationDate = new DateTime(2015)
            },
            new Car()
            {
                Id = 2,
                ManufacturerId = 1,
                Model = "Galand",
                price = 8000,
                CreationDate = new DateTime(1998)
            },
            new Car()
            {
                Id = 3,
                ManufacturerId = 2,
                Model = "Civic",
                price = 7000,
                CreationDate = new DateTime(2009)
            },
            new Car()
            {
                Id = 4,
                ManufacturerId = 3,
                Model = "Outback",
                price = 13000,
                CreationDate = new DateTime(2010)
            },
        };
        public static List<Manufacturer> Manufacturers = new List<Manufacturer>()
        {
            new Manufacturer()
            {
                id = 1,
                Name = "Mitsubishi"
            },
            new Manufacturer()
            {
                id = 2,
                Name = "Honda"
            },
            new Manufacturer()
            {
                id = 3,
                Name = "Subaru"
            },
        };
    }
}
