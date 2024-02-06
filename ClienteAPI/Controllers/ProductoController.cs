using ClienteAPI.Data;
using ClienteAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private readonly AppDBContext _dbContext;

        public ProductoController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("listar")]
        public List<Producto> askdfhasdfjklasdfhkljashjfkhaskjfhlkaj()
        {
            List<Producto> lstProductos = _dbContext.Productos.ToList();
            return lstProductos;
        }
        [HttpPost("registrar")]
        public IActionResult Registrar(Producto producto) {
            _dbContext.Productos.Add(producto);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
