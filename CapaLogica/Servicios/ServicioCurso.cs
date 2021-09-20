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
    public class ServicioCurso: servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioCurso()
        {
            respuesta = "";
            miComando = new SqlCommand();

        }

        public string InsertarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Curso");
            miComando.CommandText = "InsertarCurso";

            miComando.Parameters.Add("Curso_nombre", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("Curso_creditos", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("Curso_cupo", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("Curso_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Curso";

            Console.WriteLine("Fin del Servicio Insertar Curso");
            return respuesta;
        }

        public string ModificarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Curso");
            miComando.CommandText = "ModificarCurso";

            miComando.Parameters.Add("Curso_id", System.Data.SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = elCurso.Curso_id;

            miComando.Parameters.Add("Curso_nombre", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("Curso_creditos", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("Curso_cupo", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("Curso_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Curso";

            Console.WriteLine("Fin del Servicio Insertar Curso");
            return respuesta;
        }

        public DataSet ConsultarCurso(int Curso_id)
        {
            miComando.CommandText = "ConsultarCurso";
            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);
            this.cerrarconexion();

            return miDataSet;

        }

        public DataTable ListarCurso()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Curso");

            miComando.CommandText = "ListarCurso";
            DataSet elCurso = new DataSet();
            this.abrirconexion();

            elCurso = this.SeleccinarInformacion(miComando);
            DataTable miTabla = elCurso.Tables[0];

            return miTabla;
        }
        public string inactivarCurso(int Curso_id)
        {
            miComando.CommandText = "InactivarCurso";
            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Curso";

            Console.WriteLine("Fin servicio InactivararCurso");

            return respuesta;
        }
        public string eliminarCurso(int Curso_id)
        {
            miComando.CommandText = "EliminarCurso";
            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Curso";

            Console.WriteLine("Fin servicio EliminarCurso");

            return respuesta;
        }

    }

}
