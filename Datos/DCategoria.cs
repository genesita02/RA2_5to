using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using System.Security.Cryptography;

namespace Datos
{


    public class UserRepository
    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=ususario;Integrated Security=True;TrustServerCertificate=True";


        public User IngresarAlSistema(string usuario, string contraseña)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("IngresarAlSistema", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        Id = (int)reader["Id"],
                        usuario = (string)reader["usuario"],
                        contraseña = (string)reader["contraseña"],
                    };
                }
            }
            return user;
        }
    }
}
        