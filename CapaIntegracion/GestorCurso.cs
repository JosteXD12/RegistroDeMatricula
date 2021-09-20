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
    public class GestorCurso : servicio, IDisposable
    {
        public GestorCurso()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarCurso(string Curso_nombre, string Curso_creditos, string Curso_cupo, string Curso_estado)
        {
            Curso newCurso = new Curso(Curso_nombre, Curso_creditos, Curso_cupo, Curso_estado);

            using (ServicioCurso elCurso = new ServicioCurso())
                return elCurso.InsertarCurso(newCurso);
        }
        public string ModificarCurso(int Curso_id,string Curso_nombre, string Curso_creditos, string Curso_cupo, string Curso_estado)
        {
            Curso newCurso = new Curso(Curso_id, Curso_nombre, Curso_creditos, Curso_cupo, Curso_estado);

            using (ServicioCurso elCurso = new ServicioCurso())
                return elCurso.ModificarCurso(newCurso);
        }
        public DataSet ConsultarCurso(int Curso_id)
        {

            using (ServicioCurso elcurso = new ServicioCurso())
                return elcurso.ConsultarCurso(Curso_id);
        }

        public DataTable ListarCurso()
        {

            using (ServicioCurso elcurso = new ServicioCurso())
                return elcurso.ListarCurso();
        }
        public string eliminarCurso(int Curso_id)
        {
            using (ServicioCurso elCurso = new ServicioCurso())
                return elCurso.eliminarCurso(Curso_id);
        }

        public string inactivarCurso(int Curso_id)
        {
            using (ServicioCurso elCurso = new ServicioCurso())
                return elCurso.inactivarCurso(Curso_id);
        }
    }
}
