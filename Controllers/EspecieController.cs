using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WorldPetApi.Entities;
using WorldPetApi.Model;

namespace WorldPetApi.Controllers
{
    [Route("[controller]")]
    public class EspecieController : Controller
    {
        private readonly ILogger<EspecieController> _logger;
        private readonly Data.AppDbContext _dbContext;

        public EspecieController(
            ILogger<EspecieController> logger,
            Data.AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _dbContext.Especie.ToList();

            return Ok(result);
        }

        [HttpPost("nova-especie")]
        public IActionResult NovaEspecie(string nomeEspecie)
        {
            var especie = new Especie();
            especie.Id = Guid.NewGuid();
            especie.Descricao = nomeEspecie;
            especie.Raca = null;

            _dbContext.Especie.Add(especie);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}