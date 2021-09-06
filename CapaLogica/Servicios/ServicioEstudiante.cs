using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resgistro_de_Matricula.CapaConexion;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;

namespace Resgistro_de_Matricula.CapaLogica.Servicios
{
    public class ServicioEstudiante : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioEstudiante()
        {
            respuesta = "";
            miComando = new SqlCommand();

        }
        
        public string InsertarEstudiante(Estudiante elEstudiante)
    {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Estudiante");
            miComando.CommandText = "InsertarEstudiante";

            miComando.Parameters.Add("Estudiante_cedula", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("Estudiante_nombre", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("Estudiante_primerApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("Estudiante_segundoApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("Estudiante_Telefono", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_Telefono"].Value = elEstudiante.Estudiante_Telefono;

            miComando.Parameters.Add("Estudiante_correoElectronico", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("Estudiante_direccion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("Estudiante_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Estudiante";

            Console.WriteLine("Fin del Servicio Insertar Estudiante ");
            return respuesta;
        }

        public string ModificarEstudiante(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Estudiante");
            miComando.CommandText = "ModificarEstudiante";

            miComando.Parameters.Add("Estudiante_id", System.Data.SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = elEstudiante.Estudiante_id;

            miComando.Parameters.Add("Estudiante_cedula", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("Estudiante_nombre", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("Estudiante_primerApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("Estudiante_segundoApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("Estudiante_Telefono", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_Telefono"].Value = elEstudiante.Estudiante_Telefono;

            miComando.Parameters.Add("Estudiante_correoElectronico", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("Estudiante_direccion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("Estudiante_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Modificar Estudiante";

            Console.WriteLine("Fin del Servicio Modificar Estudiante");
            return respuesta;
        }
        public DataSet ConsultarEstudiante(int Estudiante_id)
        {
            miComando.CommandText = "ConsultarEstudiante";
            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);
            this.cerrarconexion();

            return miDataSet;

        }

        public DataTable ListarEstudiante()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Estudiante");

            miComando.CommandText = "ListarEstudiantes";
            DataSet elEstudiante = new DataSet();
            this.abrirconexion();

            elEstudiante = this.SeleccinarInformacion(miComando);
            DataTable miTabla = elEstudiante.Tables[0];

            return miTabla;
        }
        public string inactivarEstudiantes(int Estudiante_id)
        {
            miComando.CommandText = "InactivarEstudiante";
            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Estudiante";

            Console.WriteLine("Fin servicio InactivararEstudiante");

            return respuesta;
        }
        public string eliminarEstudiante(int Estudiante_id)
        {
            miComando.CommandText = "EliminarEstudiante";
            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Estudiante";

            Console.WriteLine("Fin servicio EliminarEstudiante");

            return respuesta;
        }
    }
}
