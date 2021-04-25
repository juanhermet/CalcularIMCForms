using CalcularIMCForms.Data;
using CalcularIMCForms.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMCForms.DataBusiness
{
    class ABMValores
    {
        static ConexionDataBase dataBase = new ConexionDataBase();
        
        public static void agregarValor(Valores valores)
        {
            const string query = "INSERT INTO valores(id_paciente,peso,talla,fecha) " +
                "VALUES(@id_paciente,@peso,@talla,@fecha)";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@id_paciente", valores.PacienteId);
            command.Parameters.AddWithValue("@peso", valores.Peso);
            command.Parameters.AddWithValue("@talla", valores.Talla);
            command.Parameters.AddWithValue("@fecha", valores.Fecha);
            try
            {
                dataBase.open();
                int resultado = command.ExecuteNonQuery();
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ocurrió un problema en Agregar valores:");
            }
        }
        public static void eliminarUltimoValorAgregado(int idPaciente)
        {
            int ultimoId = obtenerUltimoId();
            const string query = "DELETE FROM valores WHERE id_paciente=@id_paciente and id = @id";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@id_paciente",idPaciente);
            command.Parameters.AddWithValue("@id", ultimoId);
            try
            {
                dataBase.open();
                int resultado = command.ExecuteNonQuery();
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"problemas con borrar el último valor:");
            }
        }
        private static int obtenerUltimoId()
        {
            int ultimoId = 0;
            const string query = "SELECT id FROM valores GROUP BY id DESC";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            try
            {
                dataBase.open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ultimoId = Convert.ToInt32(reader["id"]);
                }
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"problemas con busqueda de último id:");
            }
            return ultimoId;
        }
        public static void borrarHistorialCompleto(int idPaciente)
        {
            const string query = "DELETE FROM valores WHERE id_paciente=@id_paciente";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@id_paciente", idPaciente);
           
            try
            {
                dataBase.open();
                int resultado = command.ExecuteNonQuery();
                dataBase.close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "problemas con borrar el último valor:");
            }
        }
        public static List<Valores> obtenerTodosLosValoresDelPaciente(string dni)
        {
            List<Valores> encontrado = new List<Valores>();
            const string query = "SELECT peso,talla,fecha FROM valores v " +
                "JOIN paciente p ON v.id_paciente = p.id WHERE p.DNI = @DNI";
            SqlCommand command = new SqlCommand(query, dataBase.getSqlConnection());
            command.Parameters.AddWithValue("@DNI", dni);
            try
            {
                dataBase.open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    encontrado.Add(
                        new Valores()
                        {
                            Peso = Convert.ToDouble(reader["peso"]),
                            Talla = Convert.ToDouble(reader["talla"]),
                            Fecha = Convert.ToDateTime(reader["fecha"]),
                        });
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
