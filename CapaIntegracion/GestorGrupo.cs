
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;
using Resgistro_de_Matricula.CapaLogica.Servicios;
using Resgistro_de_Matricula.CapaConexion;
using System.Data;

namespace Resgistro_de_Matricula.CapaIntegracion
{
    public class GestorGrupo : servicio, IDisposable
    {
        public GestorGrupo()
        {
                
        }
        public void Dispose()
        {

        }
        public string InsertarGrupo(string Grupo_descripcion, string Grupo_estado)
        {
            Grupo newGrupo = new Grupo(Grupo_descripcion, Grupo_estado);

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.InsertarGrupo(newGrupo);
        }

        public string ModificarGrupo(int Grupo_id,string Grupo_descripcion, string Grupo_estado)
        {
            Grupo newGrupo = new Grupo(Grupo_id, Grupo_descripcion, Grupo_estado);

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ModificarGrupo(newGrupo);
        }
        public DataSet ConsultarGrupo(int Grupo_id)
        {

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ConsultarGrupo(Grupo_id);
        }
        public DataSet ActivarGrupo(int Grupo_id)
        {

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ActivarGrupo(Grupo_id);
        }

        public DataTable ListarGrupo()
        {

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ListarGrupo();
        }

        public DataTable ListarInactivoGrupo()
        {

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ListarInactivoGrupo();
        }
        public string eliminarGrupo(int Grupo_id)
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.eliminarGrupo(Grupo_id);
        }

        public string inactivarGrupo(int Grupo_id)
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.inactivarGrupo(Grupo_id);
        }
    }
}
