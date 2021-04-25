using Hangfire.PostgreSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMCForms.Data
{
    class ConexionDataBase
    {
        const string conexion = @"Server=DESKTOP-6LMQ8E6;Database=PacientesDB;Trusted_Connection=True;";
        SqlConnection sqlConnection;
        public ConexionDataBase()
        {
            sqlConnection = new SqlConnection(conexion);
        }

        public SqlConnection getSqlConnection()
        {
            return sqlConnection;
        }
        public void open()
        {
            sqlConnection.Open();
        }
        public void close()
        {
            sqlConnection.Close();
        }
    }
}
