
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
    public class GestorProfesor : servicio, IDisposable
    {
        public GestorProfesor()
        {

        }

        public void Dispose()
        {

        }


        public string InsertarProfesor(string Profesor_cedula, string Profesor_nombre, string Profesor_primerApellido,
        string Profesor_segundoApellido, string Profesor_Telefono, string Profesor_correoElectronico, string Profesor_direccion,
                            string Profesor_estado)
        {
            Profesor newProfesor = new Profesor(Profesor_cedula, Profesor_nombre, Profesor_primerApellido, Profesor_segundoApellido,
                Profesor_Telefono, Profesor_correoElectronico, Profesor_direccion, Profesor_estado);

            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.InsertarProfesor(newProfesor);
        }

        public string ModificarProfesor(int Profesor_id, string Profesor_cedula, string Profesor_nombre, string Profesor_primerApellido,
            string Profesor_segundoApellido, string Profesor_Telefono, string Profesor_correoElectronico, string Profesor_direccion,
            string Profesor_estado)
        {
            Profesor newProfesor = new Profesor(Profesor_id, Profesor_cedula, Profesor_nombre, Profesor_primerApellido, Profesor_segundoApellido,
                Profesor_Telefono, Profesor_correoElectronico, Profesor_direccion, Profesor_estado);

            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.ModificarProfesor(newProfesor);
        }

        public DataSet consultarProfesor(int Profesor_id)
        {

            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.consultarProfesor(Profesor_id);
        }
        public DataSet ActivarProfesor(int Profesor_id)
        {

            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.ActivarProfesor(Profesor_id);
        }

        public DataTable ListarProfesor()
        {

            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.ListarProfesor();
        }
        public DataTable ListarInactivoProfesor()
        {

            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.ListarIncativoProfesor();
        }

        public string eliminarProfesor(int Profesor_id)
        {
            using (ServicioProfesor elprofesor = new ServicioProfesor())
                return elprofesor.eliminarProfesor(Profesor_id);
        }

        public string inactivarProfesor(int Profesor_id)
        {
            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.inactivarProfesor(Profesor_id);
        }
    }
}
