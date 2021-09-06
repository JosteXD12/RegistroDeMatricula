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
    public class GestorMatricula : servicio, IDisposable
    {

        public GestorMatricula()
        {

        }
        public void Dispose()
        {

        }

        public string InsertarMatricula(int Estudiante_id, int Grupo_id, int Curso_id,
            int Profesor_id, int Horario_id, int Aula_id, string Matricula_comprobante, string Matricula_estado)
        {
            Matricula newMatricula = new Matricula (Estudiante_id, Grupo_id, Curso_id, Profesor_id, Horario_id, Aula_id, Matricula_comprobante, Matricula_estado);

            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.InsertarMatricula(newMatricula);
        }

        public string ModificarMatricula(int Matricula_id, int Estudiante_id, int Grupo_id, int Curso_id,
            int Profesor_id, int Horario_id, int Aula_id, string Matricula_comprobante, string Matricula_estado)
        {
            Matricula newMatricula = new Matricula(Estudiante_id, Grupo_id, Curso_id, Profesor_id, Horario_id, Aula_id, Matricula_comprobante, Matricula_estado);

            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.ModificarMatricula(newMatricula);
        }

        public DataSet consultarMatricula(int Matricula_Id)
        {

            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.consultarMatricula(Matricula_Id);
        }
            
        public DataTable ListarMatricula()
        {

            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.ListarMatricula();
        }
        public string eliminarMatricula(int Matricula_Id)
        {
            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.eliminarMatricula(Matricula_Id);
        }

        public string inactivarMatricula(int Matricula_Id)
        {
            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.inactivarMatricula(Matricula_Id);
        }
    }
}


