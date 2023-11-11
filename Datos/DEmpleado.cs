using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;





namespace Datos
{
    public class DEmpleado
    {
       public static List<Empleado> GetAll()
        {
            var r = new List<Empleado>();
            try
            {

                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                //para funcionar, datos tiene que tener los nuggets en paquetes
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllEmpleados", connection);
                //nombre del sp en sql
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //comando de lectura
                while (reader.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.id = Convert.ToInt32(reader["id"]);
                    empleado.nombre = reader["nombre"].ToString();
                    empleado.apellido = reader["apellido"].ToString();
                    empleado.legajo=Convert.ToInt32(reader["legajo"]);
                    r.Add(empleado);
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return r;
        }

        public static void InsertEmpleado (string nombre, string apellido, int legajo)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("InsertEmpleado", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@legajo", legajo);
                connection.Open();
                command.ExecuteNonQuery();
                //comando de ejecucion, con eso se agrega el empleado
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteEmpleado(int id)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection=new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("DeleteEmpleado", connection);
                command.CommandType=System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateEmpleado(int id, string nombre, string apellido, int legajo)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conection"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand cmd = new SqlCommand("UpdateEmpleado", connection);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@legajo",legajo);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }catch(Exception){
                throw;
            }
        }
    }
}
