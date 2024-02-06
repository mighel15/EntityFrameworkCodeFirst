using ClienteAPI.Data;
using ClienteAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly AppDBContext _dbContext;

        public ClienteController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //json
        [HttpGet("listar")]
        public List<Cliente> Listar()
        {
            List<Cliente> lstClientes = _dbContext.Clientes.ToList();
            return lstClientes;

            //List<Cliente> lstClientes = new List<Cliente>();
            //Cliente cliente = new Cliente();
            //cliente.idCodigo = 1;
            //cliente.Apellido = "Perez Quispe";
            //cliente.Nombre = "Juan Pablo";
            //cliente.NumeroCelular = "987987987";
            //cliente.Talla = 1.89F;
            //cliente.Edad = 23;

            //lstClientes.Add(cliente);

            //Cliente cliente2 = new Cliente();
            //cliente2.idCodigo = 2;
            //cliente2.Apellido = "Morales Morales";
            //cliente2.Nombre = "Maria";
            //cliente2.NumeroCelular = "123123123";
            //cliente2.Talla = 1.69F;
            //cliente2.Edad = 22;
            //lstClientes.Add(cliente2);
            

            //return lstClientes;
        }
        [HttpPost("registrar")]
        public IActionResult Registrar(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();

            return Ok();
        } 
    }
}
