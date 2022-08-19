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
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly Data.AppDbContext _dbContext;

        public ClienteController(ILogger<ClienteController> logger, 
        Data.AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("buscar-todos")]
        public IActionResult Index()
        {
            return Ok(_dbContext.Cliente.ToList());
        }

        [HttpGet("buscar/{Id}")]
        public IActionResult BuscarPorId(Guid Id)
        {
            return Ok(_dbContext.Cliente.Where(c=>c.Id == Id));
        }

        [HttpPost("adicionar-cliente")]
        public IActionResult AdicionarCliente([FromBody] ClienteModel cliente)
        {
            var obj = new Cliente
            {
                Id = Guid.NewGuid(),
                Celular = cliente.Celular,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Pets = null,
                PrimeiroNome = cliente.PrimeiroNome
            };

            _dbContext.Add(obj);
            _dbContext.SaveChanges();

            return Ok();
        }


        [HttpPut("{Id}/atualizar")]
        public IActionResult AlterarCliente(Guid Id, [FromBody]ClienteModel dadosNovos)
        {
            var cliente  = _dbContext.Cliente.FirstOrDefault(c=> c.Id == Id);
            cliente.Celular = dadosNovos.Celular;
            cliente.Cpf = dadosNovos.Cpf;
            cliente.Email = dadosNovos.Email;
            cliente.PrimeiroNome = dadosNovos.PrimeiroNome;
            
            _dbContext.Cliente.Update(cliente);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}