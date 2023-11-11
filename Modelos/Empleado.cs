using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }  

        public string apellido { get; set; }    

        public int legajo { get; set; }

        public Empleado(int id, string nombre, string apellido, int legajo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public Empleado()
        {
            //se usa para el get all de datos
        }

    }
}
