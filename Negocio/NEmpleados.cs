using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Negocio
{
    public class NEmpleados
    {
        public static List<Empleado> Get ()
        {
            try
            {
                return DEmpleado.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Insert(string nombre, string apellido, int legajo)
        {
            try
            {
                DEmpleado.InsertEmpleado(nombre, apellido, legajo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Update(int id,string nombre, string apellido, int legajo)
        {
            try
            {
                DEmpleado.UpdateEmpleado(id, nombre, apellido, legajo); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                DEmpleado.DeleteEmpleado(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
