using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldPetApi.Entities;
using WorldPetApi.Model;

namespace WorldPetApi.Controllers
{
    [Route("[controller]")]
    public class PetController : Controller
    {
        private readonly ILogger<PetController> _logger;
        private readonly Data.AppDbContext _dbContext;

        public PetController(ILogger<PetController> logger,
        Data.AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("{IdCliente}/buscar-todos")]
        public IActionResult Index(Guid IdCliente)
        {
            var result = _dbContext.Pet.Where(p => p.ClienteId == IdCliente).ToList();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public IActionResult BuscarPet(Guid Id)
        {
            var pet = _dbContext.Pet.FirstOrDefault(p => p.Id == Id); 
            return Ok(pet);
        }

        [HttpPost("{IdCliente}/novo-pet")]
        public IActionResult NovoPet(Guid IdCliente, [FromBody] PetModel model)
        {
            var pet = new Pet();
            pet.ClienteId = IdCliente;
            pet.EspecieId = model.IdEspecie;
            pet.RacaId = model.IdRaca;
            pet.Nome = model.Nome;
            
            _dbContext.Add(pet);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}