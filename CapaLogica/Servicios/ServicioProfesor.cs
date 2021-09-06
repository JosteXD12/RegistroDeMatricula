using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliteca 
using Resgistro_de_Matricula.CapaConexion;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;

namespace Resgistro_de_Matricula.CapaLogica.Servicios
{
    public class ServicioProfesor:servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioProfesor()
        {
            respuesta = "";
            miComando = new SqlCommand();
             
        }
        public string InsertarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Profesor");
            miComando.CommandText = "InsertarProfesor";

            miComando.Parameters.Add("Profesor_cedula", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("Profesor_nombre", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("Profesor_primerApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("Profesor_segundoApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("Profesor_Telefono", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_Telefono"].Value = elProfesor.Profesor_Telefono;

            miComando.Parameters.Add("Profesor_correoElectronico", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("Profesor_direccion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("Profesor_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_estado"].Value = elProfesor.Profesor_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Profesor";

            Console.WriteLine("Fin del Servicio Insertar Profesor");
            return respuesta;
        }
        public string ModificarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Profesor");
            miComando.CommandText = "ModificarProfesor";

            miComando.Parameters.Add("Profesor_id", System.Data.SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = elProfesor.Profesor_id;

            miComando.Parameters.Add("Profesor_cedula", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("Profesor_nombre", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("Profesor_primerApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("Profesor_segundoApellido", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("Profesor_Telefono", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_Telefono"].Value = elProfesor.Profesor_Telefono;

            miComando.Parameters.Add("Profesor_correoElectronico", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("Profesor_direccion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("Profesor_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Profesor_estado"].Value = elProfesor.Profesor_estado;

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Modificar Profesor";

            Console.WriteLine("Fin del Servicio Modificar Profesor");

            return respuesta;
        }
        public DataSet consultarProfesor(int Profesor_id)
        {
            miComando.CommandText = "ConsultarProfesor";
            miComando.Parameters.AddWithValue(@"Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = Profesor_id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);

            this.cerrarconexion();
            return miDataSet;
        }
        public DataTable ListarProfesor()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Profesor");
            miComando.CommandText = "ListarProfesor";

            DataSet elProfesor = new DataSet();
            this.abrirconexion();
            elProfesor = this.SeleccinarInformacion(miComando);
            DataTable miTabla = elProfesor.Tables[0];

            return miTabla;

        }
        //mio
        public string inactivarProfesor(int Profesor_id)
        {
            miComando.CommandText = "InactivarProfesor";
            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Profesor";

            Console.WriteLine("Fin servicio InactivararProfesor");

            return respuesta;
        }

        public string eliminarProfesor(int Profesor_id)
        {
            miComando.CommandText = "EliminarProfesor";
            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Profesor";

            Console.WriteLine("Fin servicio EliminarProfesor");

            return respuesta;
        }

    }
}
