using ClienteAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ClienteAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() 
        { 
            
        }

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        //public DbSet<Persona> PersonaTipos { get; set; }
        //public DbSet<Persona> Personas { get; set; }
        
    }
}
