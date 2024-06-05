using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class D_cliente

    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=ususario;Integrated Security=True;TrustServerCertificate=True";

        public void spGuardarCliente(E_cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spGuardarCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                if (cliente.Id != 0)
                {
                    command.Parameters.AddWithValue("@Id", cliente.Id);
                }
                else
                {
                    command.Parameters.AddWithValue("@Id", DBNull.Value);
                }
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Contraseña", cliente.Contraseña);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
