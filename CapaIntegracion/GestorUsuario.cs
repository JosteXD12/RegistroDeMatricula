using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;
using Resgistro_de_Matricula.CapaLogica.Servicios;
using Resgistro_de_Matricula.CapaConexion;
using System.Data;

namespace CapaIntegracion
{
    public class GestorUsuario : servicio, IDisposable
    {
        public GestorUsuario()
        {

        }
        public void Dispose()
        {

        }

        public DataSet Login(String Nick, string Contraseña)
        {
            Usuario usuario = new Usuario();
            usuario.nick = Nick;
            usuario.contrasenia = Contraseña;

            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.login(usuario);
            }
        }
    }
}
