using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea6.Models
{
    public class Tesoro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Lat_y_Long { get; set; }
        public string Valor { get; set; }
        public string Peso { get; set; }
        public string URL { get; set; }
        public int Usuario { get; set; }
    }
}
