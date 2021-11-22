/*using System;//
using System.Collections.Generic;//
using System.Linq;//
using System.Text;//
using System.Threading.Tasks;//
using System.Data.SqlClient;//

namespace Entidades
{
    public static class ProductoAccesoDatos
    {
        static string ConnectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static ProductoAccesoDatos()
        {

            ConnectionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog=Cerizza;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;



        }

        public static List<Producto> Leer()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM productos";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    productos.Add(new Producto(dataReader[""].ToString(), dataReader["APELLIDO"].ToString()));
                }
                return personas;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"INSERT INTO PERSONAS (nombre,apellido) VALUES (@nombre, @apellido)";

                command.Parameters.AddWithValue("@nombre", persona.nombre);
                command.Parameters.AddWithValue("@apellido", persona.apellido);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"DELETE FROM PERSONAS WHERE ID = (@id)";
                command.Parameters.AddWithValue("@id", persona.id);

                command.ExecuteNonQuery();
            }
            catch
            {
                throw;

            }

            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(Persona nuevaPersona)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"UPDATE PERSONAS SET NOMBRE = @nombre, apellido = @apellido WHERE ID = @ID";
                command.Parameters.AddWithValue("@nombre", nuevaPersona.nombre);
                command.Parameters.AddWithValue("@apellido", nuevaPersona.apellido);
                command.Parameters.AddWithValue("@ID", nuevaPersona.Id);

                command.ExecuteNonQuery();
            }
            catch
            {
                throw;

            }

            finally
            {
                connection.Close();
            }
        }
    }
}*/
