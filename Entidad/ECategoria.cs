using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Entidad
{
   
    public class User
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }

   
    


}
