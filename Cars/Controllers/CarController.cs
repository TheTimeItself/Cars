using Microsoft.AspNetCore.Mvc;
using CarsDL.Interfaces;
using CarsDL.Repositories;
using CarsBL.Services;
using CarsBL.Interfaces;
using CarsModels.Models;

namespace Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetByID")]
        public Car? GetByID(int id)
        {
            if (id < 0) return null;

            return _carService.GetByID(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Car car)
        {
            _carService.Add(car);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _carService.Remove(id);
        }
        [HttpGet("GetAll")]
        public void GetAll(int id)
        {
            _carService.GetAll();
        }
    }
}
