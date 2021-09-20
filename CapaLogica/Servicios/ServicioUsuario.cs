using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Resgistro_de_Matricula.CapaConexion;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;

namespace Resgistro_de_Matricula.CapaLogica.Servicios
{
    public class ServicioUsuario : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;
        public void Dispose()
        {

        }
        public ServicioUsuario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public DataSet login(Usuario user)
        {
            SqlCommand command = new SqlCommand("UsuarioLogin");
            command.Parameters.AddWithValue("@nick", user.nick);
            command.Parameters.AddWithValue("@contrasenia", user.contrasenia);
            return this.SeleccinarInformacion(command);
        }
    }
}
