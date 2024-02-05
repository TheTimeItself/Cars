using CarsBL.Interfaces;
using CarsModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet("GetByID")]
        public Manufacturer? GetByID(int id)
        {
            if (id < 0) return null;

            return _manufacturerService.GetByID(id);
        }

        [HttpGet("Add")]
        public void Add([FromBody] Manufacturer Manufacturer)
        {
            _manufacturerService.Add(Manufacturer);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _manufacturerService.Remove(id);
        }

        [HttpGet("GetAll")]
        public void GetAll()
        {
            _manufacturerService.GetAll();
        }
    }
}
