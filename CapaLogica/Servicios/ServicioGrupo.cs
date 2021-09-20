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
    public class ServicioGrupo : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioGrupo()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarGrupo(Grupo elGrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Grupo");
            miComando.CommandText = "InsertarGrupo";

            miComando.Parameters.Add("Grupo_descripcion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Grupo_descripcion"].Value = elGrupo.Grupo_descripcion;

            miComando.Parameters.Add("Grupo_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Grupo_estado"].Value = elGrupo.Grupo_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Grupo";

            Console.WriteLine("Fin del Servicio Insertar Grupo");
            return respuesta;
        }

        public string ModificarGrupo(Grupo elGrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Grupo");
            miComando.CommandText = "ModificarGrupo";

            miComando.Parameters.Add("Grupo_id", System.Data.SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elGrupo.Grupo_id;

            miComando.Parameters.Add("Grupo_descripcion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Grupo_descripcion"].Value = elGrupo.Grupo_descripcion;

            miComando.Parameters.Add("Grupo_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Grupo_estado"].Value = elGrupo.Grupo_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Grupo";

            Console.WriteLine("Fin del Servicio Modificar Grupo");
            return respuesta;
        }

        public DataSet ConsultarGrupo(int Grupo_id)
        {
            miComando.CommandText = "ConsultarGrupo";
            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);
            this.cerrarconexion();

            return miDataSet;

        }

        public DataTable ListarGrupo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Horario");

            miComando.CommandText = "ListarGrupo";
            DataSet elGrupo = new DataSet();
            this.abrirconexion();

            elGrupo = this.SeleccinarInformacion(miComando);
            DataTable miTabla = elGrupo.Tables[0];

            return miTabla;
        }
        public string inactivarGrupo(int Grupo_id)
        {
            miComando.CommandText = "InactivarGrupo";
            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Grupo";

            Console.WriteLine("Fin servicio InactivararGrupo");

            return respuesta;
        }
        public string eliminarGrupo(int Grupo_id)
        {
            miComando.CommandText = "EliminarGrupo";
            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Grupo";

            Console.WriteLine("Fin servicio EliminarGrupo");

            return respuesta;
        }

    }
}
