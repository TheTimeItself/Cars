using Microsoft.AspNetCore.Http;
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
    public class ManufactorerController : ControllerBase
    {
        private readonly IManufactorerService _manufactorerService;

        public ManufactorerController(IManufactorerService manufactorerService)
        {
            _manufactorerService = manufactorerService;
        }

        [HttpGet("GetByID")]
        public Manufactorer? GetByID(int id)
        {
            if (id < 0) return null;

            return _manufactorerService.GetByID(id);
        }

        [HttpGet("Add")]
        public void Add([FromBody] Manufactorer manufactorer)
        {
            _manufactorerService.Add(manufactorer);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _manufactorerService.Remove(id);
        }

        [HttpGet("GetAll")]
        public void GetAll()
        {
            _manufactorerService.GetAll();
        }
    }
}
