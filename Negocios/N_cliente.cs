using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Negocios
{
    public class N_cliente
    {
        private D_cliente dataAccess = new D_cliente();

        public void spGuardarCliente(E_cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException("El cliente no puede ser nulo.");
            }

            if (string.IsNullOrEmpty(cliente.Nombre))
            {
                throw new ArgumentException("El nombre es obligatorio.");
            }

            if (string.IsNullOrEmpty(cliente.Contraseña))
            {
                throw new ArgumentException("La contraseña es obligatoria.");
            }

            if (string.IsNullOrEmpty(cliente.Telefono))
            {
                throw new ArgumentException("El teléfono es obligatorio.");
            }

            dataAccess.spGuardarCliente(cliente);
        }
    }

}
