using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldPetApi.Entities;
using WorldPetApi.Model;

namespace WorldPetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacaController : ControllerBase
    {
        private readonly ILogger<RacaController> _logger;
        private readonly Data.AppDbContext _dbContext;

        public RacaController(ILogger<RacaController> logger,
        Data.AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("{IdEspecie}/buscar-racas")]
        public IActionResult BuscarRacas(Guid IdEspecie)
        {
            var result = _dbContext.Raca.Where(r => r.EspecieId == IdEspecie).ToList();
            return Ok(result);
        }


        [HttpPost("{IdEspecie}/adicionar-raca")]
        public IActionResult AdicionarRaca(Guid IdEspecie, [FromBody] RacaModel model)
        {
            var raca = new Raca
            {
                Descricao = model.Nome,
                EspecieId = IdEspecie,
                Id = Guid.NewGuid(),
                Especie = null,
            };

            _dbContext.Add<Raca>(raca);
            _dbContext.SaveChanges();

            return Ok();

        }
    }
}