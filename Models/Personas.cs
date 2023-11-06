using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Tarea1._3.Models
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public String nombre { get; set; }

        [MaxLength(100)]
        public String apellido { get; set; }

        public int edad { get; set; }

        [MaxLength(100)]
        public String correo { get; set; }

        [MaxLength(100)]
        public String direccion { get; set; }

    }
}
