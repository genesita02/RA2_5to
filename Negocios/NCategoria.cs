using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static Datos.UserRepository;
namespace Negocios
{
   
    public class UserService
    {
        private UserRepository IngresarAlSistema = new UserRepository();

        public bool ValidateUser(string usuario, string contraseña)
        {
            User user = IngresarAlSistema.IngresarAlSistema(usuario, contraseña);
            return user != null;
        }
    }
    public class clientRepository
    {
        private clientRepository clientRepository = new clientRepository();

        public void CreateUser(Cliente cliente)
        {
            clientRepository.spInsertarCliente(cliente);
        }

        public List<Cliente> spInsertarCliente()
        {
            return clientRepository.spInsertarCliente();
        }
    }



}
