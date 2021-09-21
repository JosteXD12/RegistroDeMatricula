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
    public class GestorEstudiante : servicio, IDisposable
    {

        public GestorEstudiante()
        {
        
        }
        public void Dispose()
        {

        }

        public string InsertarEstudiante(int Grupo_id,string Estudiante_cedula, string Estudiante_nombre, string Estudiante_primerApellido,
            string Estudiante_segundoApellido, string Estudiante_Telefono, string Estudiante_correoElectronico,
            string Estudiante_direccion, string Estudiante_estado)
        {
            Estudiante newEstudiante = new Estudiante(Grupo_id,Estudiante_cedula, Estudiante_nombre, Estudiante_primerApellido, Estudiante_segundoApellido,
                Estudiante_Telefono, Estudiante_correoElectronico, Estudiante_direccion, Estudiante_estado);

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.InsertarEstudiante(newEstudiante);
        }

        public string ModificarEstudiante(int Estudiante_id,int Grupo_id,string Estudiante_cedula, string Estudiante_nombre, string Estudiante_primerApellido,
           string Estudiante_segundoApellido, string Estudiante_Telefono, string Estudiante_correoElectronico,
           string Estudiante_direccion, string Estudiante_estado)
        {
            Estudiante newEstudiante = new Estudiante(Estudiante_id, Grupo_id,Estudiante_cedula, Estudiante_nombre, Estudiante_primerApellido, Estudiante_segundoApellido,
                Estudiante_Telefono, Estudiante_correoElectronico, Estudiante_direccion, Estudiante_estado);

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ModificarEstudiante(newEstudiante);
        }
        public DataSet ConsultarEstudiante(int Estudiante_id)
        {

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ConsultarEstudiante(Estudiante_id);
        }

        public DataSet ActivarEstudiante(int Estudiante_id)
        {

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ActivarEstudiante(Estudiante_id);
        }

        public DataTable ListarEstudiante()
        {

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ListarEstudiante();
        }
        public DataTable ListarInactivoEstudiantes()
        {

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ListarIncativoEstudiante();
        }
        public string eliminarEstudiante(int Estudiante_id)
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.eliminarEstudiante(Estudiante_id);
        }

        public string inactivarEstudiantes(int Estudiante_id)
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.inactivarEstudiantes(Estudiante_id);
        }

    }
}
