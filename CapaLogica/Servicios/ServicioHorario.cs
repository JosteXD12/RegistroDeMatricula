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
    public class ServicioHorario: servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioHorario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        public string InsertarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Horario");
            miComando.CommandText = "InsertaHorario";

            miComando.Parameters.Add("Horario_descripcion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("CHorarario_dia", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horarario_dia"].Value = elHorario.Horarario_dia;

            miComando.Parameters.Add("Horario_horaInicio", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_horaInicio"].Value = elHorario.Horario_horaInicio;

            miComando.Parameters.Add("Horario_horaFin", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_horaFin"].Value = elHorario.Horario_horaFin;

            miComando.Parameters.Add("Horario_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Insertar Horario";

            Console.WriteLine("Fin del Servicio Insertar Horario");
            return respuesta;
        }

        public string ModificarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Horario");
            miComando.CommandText = "InsertaHorario";

            miComando.Parameters.Add("Horario_id", System.Data.SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = elHorario.Horario_id;

            miComando.Parameters.Add("Horario_descripcion", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("CHorarario_dia", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horarario_dia"].Value = elHorario.Horarario_dia;

            miComando.Parameters.Add("Horario_horaInicio", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_horaInicio"].Value = elHorario.Horario_horaInicio;

            miComando.Parameters.Add("Horario_horaFin", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_horaFin"].Value = elHorario.Horario_horaFin;

            miComando.Parameters.Add("Horario_estado", System.Data.SqlDbType.VarChar);
            miComando.Parameters["Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realziado correctamente la transaccion Modificar Horario";

            Console.WriteLine("Fin del Servicio Modificar Horario");
            return respuesta;
        }
        public DataSet ConsultarHorario(int Horario_id)
        {
            miComando.CommandText = "ConsultarHorario";
            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);
            this.cerrarconexion();

            return miDataSet;

        }

        public DataTable ListarHorario()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Horario");

            miComando.CommandText = "ListarHorario";
            DataSet elHorario = new DataSet();
            this.abrirconexion();

            elHorario = this.SeleccinarInformacion(miComando);
            DataTable miTabla = elHorario.Tables[0];

            return miTabla;
        }
        public string inactivarHorario(int Horario_id)
        {
            miComando.CommandText = "InactivarHorario";
            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Horario";

            Console.WriteLine("Fin servicio InactivararHorario");

            return respuesta;
        }
        public string eliminarHorario(int Horario_id)
        {
            miComando.CommandText = "EliminarHorario";
            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Horario";

            Console.WriteLine("Fin servicio EliminarHorario");

            return respuesta;
        }

    }
}
