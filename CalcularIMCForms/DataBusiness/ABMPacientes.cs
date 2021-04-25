using CalcularIMCForms.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMCForms.Data
{
    public static class ABMPacientes
    {
        static ConexionDataBase dataBase = new ConexionDataBase();

        public static void agregarPaciente(Pacientes paciente)
        {
            const string query = "INSERT INTO paciente(nombre,apellido,DNI,direccion,telefono) " +
                "VALUES(@nombre,@apellido,@DNI,@direccion,@telefono)";
            SqlCommand command = new SqlCommand(query,dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@nombre", paciente.Nombre);
            command.Parameters.AddWithValue("@apellido", paciente.Apellido);
            command.Parameters.AddWithValue("@DNI", paciente.DNI);
            command.Parameters.AddWithValue("@Direccion", paciente.Direccion);
            command.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            try
            {
                dataBase.open();
                int resultado = command.ExecuteNonQuery();
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"Ocurrió un problema en Agregar paciente:");
            }
        }

        public static void ModificarPaciente(long id,Pacientes paciente)
        {
            const string query = "UPDATE paciente SET nombre=@nombre," +
                "apellido=@apellido," +
                "direccion=@direccion," +
                "telefono=@telefono," +
                "DNI=@DNI WHERE id = @id";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nombre", paciente.Nombre);
            command.Parameters.AddWithValue("@apellido", paciente.Apellido);
            command.Parameters.AddWithValue("@DNI", paciente.DNI);
            command.Parameters.AddWithValue("@Direccion", paciente.Direccion);
            command.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            try
            {
                dataBase.open();
                int resultado = command.ExecuteNonQuery();
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ocurrió un problema en Modificar paciente:");
            }
        }

        public static void BorrarPaciente(long id)
        {
            const string query = "DELETE FROM paciente WHERE id = @id";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            try
            {
                dataBase.open();
                int resultado = command.ExecuteNonQuery();
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ocurrió un problema en Eliminar paciente:");
            }
        }

        public static Pacientes buscarPacientePorDNI(string DNI)
        {
            const string query = "SELECT id,nombre,apellido,DNI,direccion,telefono " +
                "FROM paciente WHERE DNI=@DNI";
            Pacientes encontrado = new Pacientes();
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@DNI", DNI);
            try
            {
                dataBase.open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    encontrado.Nombre = reader["nombre"].ToString();
                    encontrado.Apellido = reader["apellido"].ToString();
                    encontrado.DNI = reader["DNI"].ToString();
                    encontrado.Direccion = reader["direccion"].ToString();
                    encontrado.Telefono = reader["telefono"].ToString();
                }
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "paso algo en buscar id por dni:");
            }
            return encontrado;
        }

        public static int obtenerIdmedianteDNI(string DNI)
        {
            int encontrado = 0;
            const string query = "SELECT id FROM paciente WHERE DNI = @DNI";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@DNI", DNI);
            try
            {
                dataBase.open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    encontrado = Convert.ToInt32(reader["id"]);
                }
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "paso algo en buscar id por dni:");
            }
            return encontrado;
        }
    }
}
