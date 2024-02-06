using System.ComponentModel.DataAnnotations;

namespace ClienteAPI.Models
{
    public class Cliente
    {
        [Key]
        public int idCodigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string NumeroCelular { get; set; }
        public float Talla { get; set; }
        public Cliente()
        {
            idCodigo = 0;
            Nombre = "";
            Apellido= "";
        }
    }
}
